/* (Luke Alcazar) 
 * (Prototype 2) 
 * (Destroys items/prefabs when they leave the screen) 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 20;
    public float bottomBound = -10;
   
    void Update()
    {
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }

        if(transform.position.z < bottomBound)
        {
            SpawnManager.gameOver = true;

            Destroy(gameObject);
        }
    }
}
