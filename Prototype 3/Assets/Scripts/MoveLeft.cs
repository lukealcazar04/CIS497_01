﻿/* (Luke Alcazar) 
 * (Challenge 3) 
 * (Makes the objects move towards the player) 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30f;
    private float leftBound = -15;
    private PlayerController playerControllerScript;


    private void Start()
    {
        playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        //transform.Translate(Vector3.left * Time.deltaTime * speed);

        //if(transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        //{
        //    Destroy(gameObject);
        //}

        if(playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if(transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
