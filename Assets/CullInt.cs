using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CullInt : MonoBehaviour
{
    
    [SerializeField]
    float radius;
    public Texture t1;
    public Texture t2;
    void Update()
    {
        gameObject.GetComponent<Renderer>().material.SetTexture("_MainTex", t1);
        gameObject.GetComponent<Renderer>().material.SetTexture("_SecondTex", t2);
        Shader.SetGlobalVector("_Position", transform.position);
        Shader.SetGlobalFloat("_Radius", radius);


    }
}
