using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float mouseSensitivity = 100f;

    public Transform playerBody; //Reference from camera to the whole 'first-person player' object. (For rotating the playerBody with 'MouseX') 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*Gather Input based on movement of the Mouse.*/ 
        //X=side-to-side, Y=up-and-down. 
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;  //Multiplying by 'Time.deltaTime' (length of time since the function was last called) ensures that rotation occurs independently from the current frame rate.  
        float MouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime; 

        playerBody.Rotate(Vector3.up * mouseX); //Rotate around the Up/Y axis, and rotate by the value of MouseX.

    }
}
