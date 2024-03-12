using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    
    public float Speed;
    public float JumpHeight;
    Rigidbody RigidBody;
    public float SprintValue = 2.0f;
    public float DistToGround = 1.0f;
    private bool isGrounded = false;

    public Text debug;
    

    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("void start");
        RigidBody = gameObject.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {

            
        if (Input.GetKey(KeyCode.W))
        {
            
            gameObject.transform.position += gameObject.transform.forward * (Speed/100.0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            
            gameObject.transform.position -= gameObject.transform.forward * (Speed/100.0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            
            gameObject.transform.position += gameObject.transform.right * (Speed/100.0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            
            gameObject.transform.position -= gameObject.transform.right * (Speed/100.0f);
        }
        if (isGrounded == true && Input.GetKeyDown( KeyCode.Space ))
        { 
            RigidBody.velocity += gameObject.transform.up * (JumpHeight);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Speed = Speed += (SprintValue/10);
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            Speed = Speed -= (SprintValue/10);
        }
        
    }

    private void FixedUpdate()
    {
        if (Physics.Raycast(transform.position, Vector3.down, DistToGround + 0.1f))
        {
            debug.text = "Grounded";
            isGrounded = true;
        }else
        {
            debug.text = "Not grounded";
            isGrounded = false;
        }
    }
    
    
}
