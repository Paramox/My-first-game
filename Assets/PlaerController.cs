using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaerController : MonoBehaviour
{
  public float mouseSensitivity = 2f;
  public GameObject camera;
  private float mouse = 0;
  private float pitch = 0;
  public float speed = 5f;
  private Rigidbody rb;
  private Vector3  direction;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
      Vector3 targetVelocity = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
      rb.velocity=new(speed*targetVelocity.x,0f,speed*targetVelocity.z); 
      mouse = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * mouseSensitivity;
      pitch -=  mouseSensitivity * Input.GetAxis("Mouse Y");
      transform.localEulerAngles = new Vector3(0, mouse, 0);
      camera.transform.localEulerAngles = new Vector3(pitch,0,0);
      
    }
}
