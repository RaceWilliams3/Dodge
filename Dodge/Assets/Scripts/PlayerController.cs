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
            rb.AddForce(-speed, 0, 0, ForceMode.Force);
        }
        if (Input.GetKey("d") && !hasDied)
        {
            rb.AddForce(speed, 0, 0, ForceMode.Force);
        }
        if (Input.GetKey("w") && !hasDied)
        {
            rb.AddForce(0, 0, speed, ForceMode.Force);
        }
        if (Input.GetKey("s") && !hasDied)
        {
            rb.AddForce(0, 0, -speed, ForceMode.Force);
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
