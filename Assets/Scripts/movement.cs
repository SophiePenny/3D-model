using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody rb;

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Velocity = rb.velocity;

        anim.SetBool("walk", false);
        anim.SetBool("idle", true);

        // move player
        if (Input.GetKey("d"))
        {
            anim.SetBool("walk", true);
            anim.SetBool("idle", false);
            Velocity.x = -3;
        }

        if (Input.GetKey("a"))
        {
            anim.SetBool("walk", true);
            anim.SetBool("idle", false);
            Velocity.x = 3;
        }

        if (Input.GetKey("s"))
        {
            anim.SetBool("walk", true);
            anim.SetBool("idle", false);
            Velocity.z = 3;
        }

        if (Input.GetKey("w"))
        {
            anim.SetBool("walk", true);
            anim.SetBool("idle", false);
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
