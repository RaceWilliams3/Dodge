using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;
    private bool hasDied = false;

    public GameManager gameManager;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey("a") && !hasDied)
        {
            rb.AddForce(-speed, 0, 0, ForceMode.Acceleration);
        }
        if (Input.GetKey("d") && !hasDied)
        {
            rb.AddForce(speed, 0, 0, ForceMode.Acceleration);
        }
        if (Input.GetKey("w") && !hasDied)
        {
            rb.AddForce(0, 0, speed, ForceMode.Acceleration);
        }
        if (Input.GetKey("s") && !hasDied)
        {
            rb.AddForce(0, 0, -speed, ForceMode.Acceleration);
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            hasDied = true;
            gameManager.playerDead = hasDied;
        }
    }
}
