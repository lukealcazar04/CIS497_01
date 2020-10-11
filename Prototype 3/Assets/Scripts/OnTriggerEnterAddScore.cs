/* (Luke Alcazar) 
 * (Challenge 3) 
 * (this adds to the score everytime you jump over obstacles) 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerEnterAddScore : MonoBehaviour
{
    private UIManager uIManager;

    private bool triggered = false;

    void Start()
    {
        uIManager = GameObject.FindObjectOfType<UIManager>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            uIManager.score++;
        }
    }
}
