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
     if(Input.GetKeyDown(KeyCode.W))
     {
        rb.velocity=new(speed,0f,0f);
     }
    }
}
