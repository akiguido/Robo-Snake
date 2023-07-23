using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyControl : MonoBehaviour
{
    //public static int numberInstance;
    public static int numberInstance;
    public GameObject Head;
    private float enunerate;
    private Vector3 bodyOffset;
    void Start()
    {
        numberInstance++;
        enunerate = numberInstance;
        bodyOffset = new Vector3(0.21f * enunerate, 0 , 0);
        Head = GameObject.Find("Head");
        transform.rotation = Head.transform.rotation;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Head.transform.rotation;
        transform.position = Head.transform.position + bodyOffset;

    }
}
