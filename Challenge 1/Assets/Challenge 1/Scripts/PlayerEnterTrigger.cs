/*
 * (Luke Alcazar)
 * (Challenge 1)
 * (This was the original trigger for the zones but was updated later)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerEnterTrigger : MonoBehaviour
{
    // Start is called before the first frame update


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriggerZone"))
        {
            ScoreManager.score++;
            
        }

    }
}
