using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeController : MonoBehaviour
{
    public float velocity;
    public GameObject BodySnake;


    //public Rigidbody snakeRB;

    void Start()
    {
        SceneController.LastParent = gameObject;
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(BodySnake,SceneController.LastParent.transform);
            //Instantiate(BodySnake);
        }
    }
}
