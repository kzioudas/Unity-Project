using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPerson : MonoBehaviour
{
    
    public float turnSpeed = 4.0f;
    public float moveSpeed = 100.0f;
    public float minTurnAngle = -90.0f;
    public float maxTurnAngle = 0.0f;
    private float rotX;

    // Update is called once per frame
    void Update()
    {
        Mouse();
        Keyboard();
    }

    void Mouse()
    {

        //getint the mouse inputs 
        float y = Input.GetAxis("Mouse X") * turnSpeed;
        rotX += Input.GetAxis("Mouse Y") * turnSpeed;

        //keeping limits on the rotation of the camera 
        rotX = Mathf.Clamp(rotX, minTurnAngle, maxTurnAngle);

        //rotate the camera 
        transform.eulerAngles = new Vector3(-rotX, transform.eulerAngles.y + y, 0);
    }

    void Keyboard()
    {
        Vector3 dir = new Vector3(0, 0, 0);

        //dir.x = Input.GetAxis("Horizontal");
        //dir.z = Input.GetAxis("Vertical");

       
        if (Input.GetKeyDown(KeyCode.A))
        {
            
            dir.x--;
            transform.Translate(dir * moveSpeed );
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            
            dir.x++;
            transform.Translate(dir * moveSpeed ); ;
        }
        
        if (Input.GetKeyDown(KeyCode.S))
        {
           
            dir.z--;
            transform.Translate(dir * moveSpeed );

        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            
            dir.z++;
            transform.Translate(dir * moveSpeed );
        }
    }

}
