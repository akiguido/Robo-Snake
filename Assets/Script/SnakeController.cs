using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeController : MonoBehaviour
{
    public float velocity;
    //public Rigidbody snakeRB;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * velocity * Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Rotate(0,0,90);
        } else if (Input.GetKeyDown(KeyCode.RightArrow)) 
        {
            transform.Rotate(0, 0, -90);
        }
    }
}
