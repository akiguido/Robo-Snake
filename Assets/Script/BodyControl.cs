using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyControl : MonoBehaviour
{
    //public static int numberInstance;
    public static int numberInstance;
    public GameObject Parent;
    private float enunerate;
    private Vector3 bodyOffset;
    void Awake()
    {
        bodyOffset = new Vector3(0, 0, 0.21f);
        SceneController.LastParent = gameObject;

        numberInstance++;
        print(numberInstance);
        //enunerate = numberInstance;
        Parent = SceneController.LastParent;
        gameObject.transform.SetParent(Parent.transform);
        transform.position += bodyOffset;
        
        
        //Head = GameObject.Find("Head");
        transform.rotation = Parent.transform.rotation;
        SceneController.LastParent = gameObject;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.rotation = Parent.transform.rotation ;

        transform.position = Parent.transform.position; //- bodyOffset;
        
        //transform.position = GetComponentInParent<Transform>().position + bodyOffset;
    }
}
