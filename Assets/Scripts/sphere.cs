using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere : MonoBehaviour
{
    public float speed = 8f;

    public float lifeduration = 2f;

    private float lifetimer;

    void Start()
    {
        lifetimer = lifeduration;
    }

    //collison with wall

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Wall")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }

    void Update()
    {
        //make the bullet move

        transform.position += transform.forward * speed * Time.deltaTime;

        //timer

        lifetimer -= Time.deltaTime;
        if (lifetimer <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
