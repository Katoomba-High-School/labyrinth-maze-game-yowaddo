using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateBoard : MonoBehaviour
{
    public float speed = 100f;
    public Rigidbody rb;

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal") * speed;
        float v = Input.GetAxis("Vertical") * speed;
        rb.AddTorque(-transform.forward * h);
        rb.AddTorque(transform.right * v);
    }
}
