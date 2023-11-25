using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
   public float mouseSensitvity =100f;

   float xRotation = 0f;

   float yRotation =0f;


    void Start()
    {
        //
        Cursor.lockState = CursorLockMode.Locked;     
    }

    void Update()
    {
      float mouseX = Input.GetAxis("Mouse X")* mouseSensitvity * Time.deltaTime;
      float mouseY = Input.GetAxis("Mouse Y")* mouseSensitvity * Time.deltaTime;




    }
}
