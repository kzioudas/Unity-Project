using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadTexture : MonoBehaviour
{

    public GameObject SPH;
    bool done = false;
    private int flag;
    public Material m;
    public Texture tex;
    private Renderer m_Renderer;

    void Start()
    {
        flag = 0;
        //SPH.GetComponent<MeshRenderer>().material = red;
        m_Renderer = GetComponent<Renderer>();
        tex = Resources.Load<Texture2D>("texture-sphere") as Texture;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("asdf");
            if(flag == 0)
            {
                Debug.Log("b");
                m_Renderer.material = null;
                m_Renderer.material.SetTexture("_MainTex",tex);
                //SPH.GetComponent<MeshRenderer>().material = tex;
                flag = 1;
            }
            else
            {
                m_Renderer.material = null;
                m_Renderer.material.color = Color.red;
                Debug.Log("a");
                //SPH.GetComponent<MeshRenderer>().material = red;
                flag = 0;
            }
            //var rend = SPH.GetComponent<Renderer>();
            //rend.sharedMaterial.mainTexture = Resources.Load("texture") as Texture2D;


        }
        
    }
}
