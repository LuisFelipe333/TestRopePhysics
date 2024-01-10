using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceToObject2d : MonoBehaviour
{
    public float Xforce;

    public float Yforce;


    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(Xforce,Yforce));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
