using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomObj : MonoBehaviour
{
    public GameObject sc;
    GameObject clone;
    Rigidbody rbc;
    Rigidbody rbs;
    Rigidbody rbcy;
    public GameObject cubeprefab;
    public GameObject sphereprefab;
    public GameObject cylinderprefab;
    private Vector3 cubeBounds;
    private float speed;
    private int ranobj;
    private float ranscale;
    private float ranvx;//random x cordinate for v
    private float ranvy; // random y cordinate for v
    private float ranvz;    // random z cordinate for v
    
   
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {   //generate randoms
            ranobj = Random.Range(1, 4);
            ranscale = Random.Range(1.0f, 10.0f);
            ranvx = Random.Range(0.1f, 0.9f);
            ranvy = Random.Range(-0.1f, -0.9f);
            ranvz = Random.Range(0.1f, 0.9f);
            spawn(ranobj, ranscale, ranvx, ranvy, ranvz);//call spawn 
        }
        
    }
    private void spawn(int i, float scale, float x, float y, float z)
    {   //creates and transforms the random obj
        Vector3 cubexyz = new Vector3(-48+scale, 48-scale, -48+scale);
        speed = 50.0f;

        switch (i)
        {
            case 1:
               
                clone = Instantiate(cubeprefab, cubexyz, Quaternion.identity);
                rbc = clone.GetComponent<Rigidbody>();
                rbc.velocity = new Vector3(x*speed, y*speed, z*speed);
                clone.transform.localScale += new Vector3(scale, scale, scale);
                clone.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
                
                break;
            case 2:
                
                clone = Instantiate(sphereprefab, cubexyz, Quaternion.identity);
                rbs = clone.GetComponent<Rigidbody>();
                rbs.velocity = new Vector3(x * speed, y * speed, z * speed);
                clone.transform.localScale += new Vector3(scale, scale, scale);
                clone.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
                
                break;
            case 3:
               
                clone = Instantiate(cylinderprefab, cubexyz, Quaternion.identity);
                rbcy = clone.GetComponent<Rigidbody>();
                rbcy.velocity = new Vector3(x * speed, y * speed, z * speed);
                clone.transform.localScale += new Vector3(scale, scale, scale);
                clone.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
                
                break;
        }




    }
}
