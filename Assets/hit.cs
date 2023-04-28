using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit : MonoBehaviour
{
    public AudioSource Auch;
    public GameObject h;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        
        if (other.gameObject.name == "Smcube(Clone)" || other.gameObject.name == "Smsphere(Clone)" || other.gameObject.name == "Smcylinder(Clone)")
        { Debug.Log("hit");
            GameObject a = Instantiate(h) as GameObject;
            a.transform.position = other.gameObject.transform.position;
            a.GetComponent<ParticleSystem>().Play();
            Auch.Play();
            //yield  new WaitForSeconds(5);
            Destroy(a,2) ;
        }
    }
}
