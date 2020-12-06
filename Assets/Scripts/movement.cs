using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Velocity = rb.velocity;

        // move player
        if (Input.GetKey("d"))
        {
            Velocity.x = -3;
        }

        if (Input.GetKey("a"))
        {
            Velocity.x = 3;
        }

        if (Input.GetKey("s"))
        {
            Velocity.z = 3;
        }

        if (Input.GetKey("w"))
        {
            Velocity.z = -3;
        }

        if (Input.GetKey("q"))
        {
            if (Velocity.y == 0)
            {
                Velocity.y += 5;
            }
        }

        rb.velocity = Velocity;
    }
}
