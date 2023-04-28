using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public GameObject a;
    void Update()
    {
        transform.LookAt(a.transform.position);
        
    }
}
