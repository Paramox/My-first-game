using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaerController : MonoBehaviour
{
  public float speed = 5f;
  private Rigidbody rb;
  private Vector3  direction;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
      Vector3 targetVelocity = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
      rb.velocity=new(speed*targetVelocity.x,0f,speed*targetVelocity.z); 
    float Mouse = transform.localEulerAngels.y + Input.GetAxis("Mouse X") * Mouse Sensitivity;
    }
   

}
