/* (Luke Alcazar) 
 * (Challenge 2) 
 * (Detects the dog colliding with the ball) 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    

    
    private void OnTriggerEnter(Collider other)
    {
        
        Destroy(gameObject);
        DisplayScore.score++;
    }
}
