using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class dircoll : MonoBehaviour
{
    //public GameObject e;
    //public ParticleEmitter particle;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider hit)
    {
        //GameObject a = Instantiate(e) as GameObject;
        var tag = hit.gameObject.tag;

        Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        Vector3 vel = rb.velocity;
        if (tag == "wallRight" || tag == "wallLeft")
        {
            //a.transform.position = rb.position;
           // Debug.Log("hit r or l");
            vel.z = -vel.z;
            //particle.emit = true;

        }
        else if (tag == "wallUp" || tag == "wallDown")
        {
           // a.transform.position = rb.position;
            //Debug.Log("hit u or d");
            vel.y = -vel.y;
            //particle.emit = true;

        }
        else if (tag == "wallFront" || tag == "wallBack")
        {
           // a.transform.position = rb.position;
           // Debug.Log("hit f or b");
            vel.x = -vel.x;
            //particle.emit = true;

        }
        else if (tag == "sph"|| tag == "Player")
        {
            //a.transform.position = rb.position;
            //Debug.Log("hit sph" );
            vel.x = -vel.x;
            vel.y = -vel.y;
            vel.z = -vel.z;
            //particle.emit = true;

        }


       //particle.emit = false;
        rb.velocity = vel ;
    }

}
