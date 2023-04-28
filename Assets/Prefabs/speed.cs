using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//thelei douleia

public class speed : MonoBehaviour
{
    
    float speedn = 1.0f;
    
    // Update is called once per frame
    void Update()
    {
        Rigidbody rb;
        rb =GetComponent<Rigidbody>();
        Vector3 vel = rb.velocity;
        vel.x = vel.x * speedn;
        vel.y = vel.y * speedn;
        vel.z = vel.z * speedn;
        if (speedn > 0)
        {
            if (Input.GetKeyDown(KeyCode.Greater) || Input.GetKeyDown(KeyCode.G))
            {

                speedn=speedn +0.01f;
                
                
                Debug.Log("speed" + speedn);
            }
            else if (Input.GetKeyDown(KeyCode.Less) || Input.GetKeyDown(KeyCode.L))
            {
                speedn = speedn - 0.01f;


                Debug.Log("speed" + speedn);
            }

        }
        else
        {
            speedn = 0;
        }
        rb.velocity = vel;


    }
}
