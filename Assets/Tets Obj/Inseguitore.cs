using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inseguitore : MonoBehaviour
{

    public Transform player;
    public float velocita = 1;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);
        if(Vector3.Distance(transform.position, player.position) > 2)
        {
            transform.position = Vector3.Lerp(transform.position, player.position, velocita * Time.deltaTime);
        }
        
    }
}
