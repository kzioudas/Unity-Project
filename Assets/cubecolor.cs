using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubecolor : MonoBehaviour
{
    void Start()
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f, 0.2f, 0.5f);

    }
}
