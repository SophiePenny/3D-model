using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwing : MonoBehaviour
{
    Rigidbody rb;
    public GameObject sphere;

    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    public void throwball()
    {
        GameObject sphereobject = Instantiate(sphere);
        sphereobject.transform.position = transform.position + transform.forward;
        sphereobject.transform.forward = transform.forward;
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
    }
}
