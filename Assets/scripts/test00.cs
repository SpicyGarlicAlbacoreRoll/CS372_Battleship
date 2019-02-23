using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test00 : MonoBehaviour
{
    public float speed = 5;
    // Start is called before the first frame update
    public Rigidbody rb;

    void Start()
    {
        // rb = GetComponent<Rigidbody>();
        // rb.AddForce(transform.)
        rb = GetComponent<Rigidbody>();

    }

    void FixedUpdate()
    {
        rb.AddForce(transform.forward * speed);
    }
}