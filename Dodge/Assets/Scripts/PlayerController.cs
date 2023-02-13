using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public int health;
    public int maxHealth;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {

    }

    void Update()
    {
        if (Input.GetKey("a"))
        {
            rb.AddForce(-speed, 0, 0, ForceMode.Acceleration);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(speed, 0, 0, ForceMode.Acceleration);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, speed, ForceMode.Acceleration);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -speed, ForceMode.Acceleration);
        }
    }
}
