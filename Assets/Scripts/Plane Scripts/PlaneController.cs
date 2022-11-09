using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    [SerializeField] private float velocitySpeed;
    [SerializeField] private float angularSpeed;
    [SerializeField] private Rigidbody body;



    
    
    private void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) 
        {
            body.velocity = transform.forward * velocitySpeed;
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow)) 
        {
            body.velocity *= 0;
        }
        
        if (Input.GetKey(KeyCode.LeftArrow)) 
        {
            body.velocity = -transform.forward * velocitySpeed;
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow)) 
        {
            body.velocity *= 0;
        }

        if (Input.GetKey(KeyCode.UpArrow)) 
        {
            body.angularVelocity = -transform.right * angularSpeed;
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow)) 
        {
            body.angularVelocity *= 0;
        }
        
        if (Input.GetKey(KeyCode.DownArrow)) 
        {
            body.angularVelocity = transform.right * angularSpeed;
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow)) 
        {
            body.angularVelocity *= 0;
        }
        
    }
}
