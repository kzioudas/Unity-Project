using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSPH : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            
            position.x--;
            
           
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            
            position.x++;
            
            
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            
            position.y++;
            
            
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            
            position.y--;
            
        }
        if (Input.GetKeyDown(KeyCode.KeypadMinus))
        {
            
            position.z--;
            
            
        }
        if (Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            
            position.z++;
           
           
        }
        transform.position = position;
    }
}
