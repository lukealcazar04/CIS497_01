using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* (Luke Alcazar) 
 * (Challenge 2) 
 * (Destroys Items when they leave the screen) 
 */


public class DestroyOutOfBoundsX : MonoBehaviour
{
    private DisplayScore displayHealth;
    private float leftLimit = -30;
    private float bottomLimit = -5;
   
    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.y < bottomLimit)
        {
            DisplayScore.health--;
            Destroy(gameObject);
            
        }

    }
}
