using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
  [SerializeField]UIManager _uiManager;

  private void Start()
    {
      _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
      if(_uiManager == null)
      {
        Debug.Log("CANVAS NULL");
      }else
      {
        Debug.Log("CANVAS GET");
      }
    }
}
