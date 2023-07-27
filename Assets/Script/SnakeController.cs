using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class SnakeController : MonoBehaviour
{
    public float velocity;
    public float rotVelocity;
    public GameObject BodySnake;


    //public Rigidbody snakeRB;

    void Start()
    {
        SceneController.LastParent = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        var bodyControlScript = SceneController.LastParent.GetComponent<BodyControl>();
        Transform myParent = SceneController.LastParent.GetComponent<Transform>();
        transform.Translate(Vector3.forward * velocity * Time.deltaTime);

        float horizontalRotate = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontalRotate * rotVelocity * Time.deltaTime);
        /*
         if(Input.GetKeyDown(KeyCode.LeftArrow))
         {
             transform.Rotate(Vector3.up, -90);

         } else if (Input.GetKeyDown(KeyCode.RightArrow)) 
         {
             transform.Rotate(Vector3.up, 90);
         }
         */

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Instantiate(BodySnake,myParent, true);
            if (bodyControlScript != null)
            {
                print($" TI STAI COLLEGANDO AL PARENT N. {bodyControlScript.enunerate}");

            }
            // tentativo di lasciare i pezzi di corpo indipendenti:
            // messi in una gerarchia Parent girano di scatto / in blocco.
            //Instantiate(BodySnake, myParent.position, myParent.rotation, myParent);
            Instantiate(BodySnake, myParent.position, myParent.rotation);
        }
    }
}
