/* (Luke Alcazar) 
 * (Challenge 2) 
 * (Manages the random spawning of Balls) 
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    public static bool gameOver = false; 

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        DisplayScore.score = 0;
        DisplayScore.health = 5;
        StartCoroutine(SpawnRandomBallCoroutine());
        //InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    private void Update()
    {
        if(DisplayScore.score == 5 || DisplayScore.health == 0)
        {
            gameOver = true;
        }
    }

    IEnumerator SpawnRandomBallCoroutine()
    {
        yield return new WaitForSeconds(3f);

        while (!gameOver)
        {
            SpawnRandomBall();

            float random = Random.Range(3f, 5f);

            yield return new WaitForSeconds(random);
        }
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        int ran = Random.Range(0, 2);
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ran], spawnPos, ballPrefabs[ran].transform.rotation);
    }

}
