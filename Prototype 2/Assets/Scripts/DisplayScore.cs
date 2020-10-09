/* (Luke Alcazar) 
 * (Prototype 2) 
 * (Displays the score for the game) 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    public Text textbox;
    public int score = 0;
    void Start()
    {
        textbox = GetComponent<Text>();
        textbox.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Score: "  + score;
        if(SpawnManager.gameOver == true)
        {
            textbox.text = "Game Over";
        }
    }
}
