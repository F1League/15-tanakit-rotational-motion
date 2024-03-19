using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MomentOfinertia : MonoBehaviour
{
    private Rigidbody rb;
    private void Start()
    {
        rb= GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        Debug.Log(this.name+"Inertia"+ rb.inertiaTensor);
        transform.localScale += new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        //GetComponent<Rigidbody>().AddTorque(10,0,0);
        rb.angularVelocity=rb.inertiaTensor;
    }
}
