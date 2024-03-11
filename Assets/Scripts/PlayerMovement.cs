using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float Speed;
    public float JumpHeight;
    Rigidbody RigidBody;
    private bool isGrounded;
    
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            RigidBody.velocity += gameObject.transform.up * (JumpHeight);
            
        }
        
    }
}
