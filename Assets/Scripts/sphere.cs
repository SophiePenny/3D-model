using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere : MonoBehaviour
{
    public float speed = 8f;

    public float lifeduration = 2f;

    private float lifetimer;
    // Start is called before the first frame update
    void Start()
    {
        lifetimer = lifeduration;
    }

    //collison

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Cube")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
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
