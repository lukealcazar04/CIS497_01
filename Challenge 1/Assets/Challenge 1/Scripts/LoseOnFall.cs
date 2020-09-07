/*
 * (Luke Alcazar)
 * (Challenge 1)
 * (This ends the game if you go above or below a certain height)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseOnFall : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -51 || transform.position.y > 80)
        {
            ScoreManager.gameOver = true;
        }


    }
}
