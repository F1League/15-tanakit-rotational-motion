using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnus_Effect : MonoBehaviour
{
    private Rigidbody rb;
    public Vector3 angularV, V;
  
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

   
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.angularVelocity = angularV;
            rb.velocity = V;
        }
        rb.AddForce(Vector3.Cross(rb.angularVelocity,rb.velocity));
    }
}
