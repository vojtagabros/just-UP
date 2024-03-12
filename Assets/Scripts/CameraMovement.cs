using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public Transform Player;
    public float MouseSensityvity = 2f;
    private float CameraVerticalRotation = 0f;

    private bool LockedCursor = true;
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Mouse X") * MouseSensityvity;
        float inputY = Input.GetAxis("Mouse Y") * MouseSensityvity;

        CameraVerticalRotation -= inputY;
        CameraVerticalRotation = Mathf.Clamp(CameraVerticalRotation, -90, 90);
        transform.localEulerAngles = Vector3.right * CameraVerticalRotation;
        
        Player.Rotate(Vector3.up * inputX);
    }
}
