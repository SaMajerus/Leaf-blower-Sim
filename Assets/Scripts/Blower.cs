using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blower : MonoBehaviour
{
  Animator blower_Animator;
  AudioSource blower_AudioSource;

  //private AudioSource[] clips;

  public float range = 10f;
  public float impactForce = 30f;

  // [field: SerializeField]
  // private float coolDown = 1f;
  // float CDTimer;

// **Will refactor  'ammo'/etc  as  'fuel'/etc  in the future, most likely.  
  /*
  [field: SerializeField]
  private int maxAmmo = 10;
  [field: SerializeField]
  private float reloadTime;
  private int ammo;
  */ 

  //private bool isIdling = true;
  private bool isBlowing = false;
  // float distanceToTarget = Mathf.Infinity;  //Copied from 'AI Variables' in TEST.cs (now 'LeafLogic.cs'). 

  public Camera fpsCam;
  public ParticleSystem muzzleFlash;
  public GameObject impactEffect;

  [field: SerializeField]
  private UIManager _uiManager;

  void Start()
  {
    blower_Animator = gameObject.GetComponent<Animator>();
    //clips = gameObject.GetComponents<AudioSource>();  //P-code note: 'Start idle-engine noise'
    _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
    // CDTimer = coolDown;
    // ammo = maxAmmo;
    // _uiManager.UpdateAmmoDisplay(ammo, maxAmmo);
  }
  
  // Update is called once per frame
  void Update()
  {
    if(!isBlowing)
    {
      return;
    }

    // if(ammo == 0)
    // {
    //   StartCoroutine(Idle());
    //   return;
    // }

    // if(CDTimer < coolDown)
    // {
    //   CDTimer += Time.deltaTime;
    // }
    if (Input.GetButton("Fire1") && isBlowing == false/*&& CDTimer >= coolDown && ammo > 0*/)
    {
      // CDTimer = 0;
      Blow(); 
    } 
    else
    {  //I'm intending for this to essentially reset the Blower to its default State: Idle/not-Blowing. 
      StartCoroutine(Idle()); 
      return; 
    } 

/*
    if(Input.GetKeyDown(KeyCode.R))
    {
      // StartCoroutine(Refuel());
      return;
    }*/
  }

  void Blow ()
  {
    isBlowing = true; 
    muzzleFlash.Play();
    // clips[Random.Range(0, clips.Length)].Play();
    // ammo--;
    RaycastHit hit;
    // _uiManager.UpdateAmmoDisplay(ammo, maxAmmo);  //Updates ammo count after Gun is fired. 
    if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit))
    {
      Debug.Log(hit.transform.name);
      GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
      Destroy(impactGO, 2f);  //To GameObject: "Destroy yourself after you've existed for 2 seconds (about same length as hit impact animation)"
      if (hit.rigidbody != null)
      {
        hit.rigidbody.AddForce(-hit.normal * impactForce);
      }

      // TEST enemy = hit.transform.GetComponent<TEST>();
      
      // if (enemy != null) 
      // {
      //   enemy.TakeDamage(damage);  //ISSUE
      // }
    }
  }


  IEnumerator Idle()
  {
    isBlowing = false; 
    blower_Animator.SetTrigger("Idle");
    Debug.Log("Idling!");
    // yield return new WaitForSeconds();
    if(isBlowing){
      Debug.Log("Blowing!");
      isBlowing = true;
      return; 
    }
    else
    {
      yield return new WaitForSeconds(1f);   //My idea, based on my limited understanding [currently], is that it'll wait for 1 second before checking if the Player has clicked the 'Fire1' button since the last check. 
    }
  }

/*
  IEnumerator Refuel()  //Will develop further once this mechanic/feature is added. 
  {
    isRefueling = true;
    // *Engine Shut-off sound*
    blower_Animator.SetTrigger("Refuel");
    Debug.Log("Refueling...");
    yield return new WaitForSeconds(refuelTime);
    Debug.Log("Refueled!"); 
    fuel = maxFuel;
    _uiManager.UpdateRefuelDisplay(fuel, maxFuel);
    isRefueling = false;
  } */

}
