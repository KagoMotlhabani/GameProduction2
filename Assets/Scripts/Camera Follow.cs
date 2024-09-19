using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //public float Xsensetivity;
    //public float Ysensetivity;
    //public float Xrotation;
    //public float Yrotation;

    //testing Comment

    public Transform orientation;//player
    public float camDelay = 0.125f;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;

    }//end start

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = orientation.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(this.transform.position, playerPosition, camDelay);
        this.transform.position = smoothedPosition;


        //this attaches the camera to the curser and allows it to rotate when the mouse rotates
        /*
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * Xsensetivity;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * Ysensetivity;

        Yrotation += mouseX;
        Xrotation -= mouseY;
        Xrotation = Mathf.Clamp(Xrotation, -90f, 90f);

        transform.rotation = Quaternion.Euler(Xrotation, Yrotation, 0);
        orientation.rotation = Quaternion.Euler(0, Yrotation, 0);
        */


    }//end update
}//end class
