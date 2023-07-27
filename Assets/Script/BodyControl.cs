using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyControl : MonoBehaviour
{
    //public static int numberInstance;
    public static int numberInstance;
    public GameObject Parent;
    public int enunerate;
    private Vector3 bodyOffset;

    public float velocityChase;
    public float distanceTail = 0.23f;

    public int GetInstance()
    {
        return enunerate;
    }

    void Awake()
    {
        //bodyOffset = new Vector3(0, 0, -0.22f);

        Parent = SceneController.LastParent;
        SceneController.LastParent = gameObject;

        numberInstance++;
        enunerate = numberInstance;
        print(numberInstance);
        //gameObject.transform.SetParent(Parent.transform);

        bodyOffset = Parent.transform.TransformDirection(new Vector3(0, 0, -0.23f));
        transform.LookAt(Parent.transform);

        transform.position += bodyOffset ;

    }

    // Update is called once per frame
    void Update()
    {

        transform.LookAt(Parent.transform);
        float dist = Vector3.Distance(transform.position, Parent.transform.position);
        print(dist);
        if (dist > distanceTail)
        {
            transform.position = Vector3.Lerp(transform.position, 
                Parent.transform.position, velocityChase * Time.deltaTime);

        }
        //transform.LookAt(Parent.transform);

    }
}
