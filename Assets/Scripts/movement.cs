using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody rb;
    public GameObject Sphere;

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    public void throwball()
    {
        //Debug.Log("throw");

        Instantiate(Sphere, new Vector3(-0.158f , -0.407f , -0.351f), Quaternion.identity);
      
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Velocity = rb.velocity;


        //throw ball
        anim.SetBool("idle", true);
        anim.SetBool("throw", false);

        if(Input.GetKeyDown("space"))
        {
            anim.SetBool("throw", true);
            anim.SetBool("idle", false);
        }

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
