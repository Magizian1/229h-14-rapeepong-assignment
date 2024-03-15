using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirPlane : MonoBehaviour
{
    public Rigidbody rb;
    public float enginePowerThrust, liftBooter, drag, angularDrag;

    

    
    void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            rb.AddForce(transform.forward * enginePowerThrust);
        }

        Vector3 lift = Vector3.Project(rb.velocity , transform.forward);
        rb.AddForce(transform.up * lift.magnitude * liftBooter);

        rb.drag = rb.velocity.magnitude * drag;
        rb.angularDrag = rb.velocity.magnitude * angularDrag;

        rb.AddTorque(Input.GetAxis("Horizontal") * transform.forward * -1);

        rb.AddTorque(Input.GetAxis("Vertical") * transform.right);
    }
}
