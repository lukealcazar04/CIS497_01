/* (Luke Alcazar) 
 * (Challenge 3) 
 * (this keeps track of the score and restarting the game) 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScore : MonoBehaviour
{
    public Text textBox;
    public int score = 0;
    public bool won = false;

    public PlayerControllerX playerControllerXScript;

    void Start()
    {
        if(textBox == null)
        {
            textBox = FindObjectOfType<Text>();
        }
        
        if(playerControllerXScript == null)
        {
            playerControllerXScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControllerX>();
        }

        textBox.text = "Score: 0";       
    }

    
    void Update()
    {
        if(score == 2)
        {
            won = true;
            playerControllerXScript.gameOver = true;
        }

        if (!playerControllerXScript.gameOver)
        {
            textBox.text = "Score: " + score;
        }

        if (playerControllerXScript.gameOver && !won)
        {
            textBox.text = "You Lose!\n Press R to Try Again";
        }

        if(playerControllerXScript.gameOver && won)
        {
            textBox.text = "You Win!\n Press R to Try Again";
        }

        if (playerControllerXScript.gameOver && Input.GetKeyDown(KeyCode.R))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
        }
    }
}
