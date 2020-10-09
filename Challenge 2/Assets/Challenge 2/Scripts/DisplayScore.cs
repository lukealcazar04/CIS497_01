/* (Luke Alcazar) 
 * (Challenge 2) 
 * (Shows and works with the score and health system) 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DisplayScore : MonoBehaviour
{
    public Text textbox1;
    public Text textbox2;
    public static int score = 0;
    public static int health = 5;

    // Start is called before the first frame update
    void Start()
    {
        textbox1.text = "Score: 0";
        textbox2.text = "Health: 5";
    }

    // Update is called once per frame
    void Update()
    {
        textbox1.text = "Score: " + score;
        textbox2.text = "Health: " + health;

        if(SpawnManagerX.gameOver == true)
        {
            textbox1.text = "GAME OVER";
            textbox2.text = "PRESS R TO RESTART";
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
