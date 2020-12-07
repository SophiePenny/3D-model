using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwing : MonoBehaviour
{
    public GameObject sphere;

    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void throwball()
    {
        //instantiate projectile
        GameObject sphereobject = Instantiate(sphere);
        sphereobject.transform.position = transform.position + transform.forward;
        sphereobject.transform.forward = transform.forward;
    }

    void Update()
    {
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
