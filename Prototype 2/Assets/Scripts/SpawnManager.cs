/* (Luke Alcazar) 
 * (Prototype 2) 
 * (Manages the randomized spawning of animals) 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] prefabsToSpawn;

    private float leftBound = -14;
    private float rightBound = 14;
    private float spawnPosZ = 20;

    public static bool gameOver = false;

    private void Start()
    {
        StartCoroutine(SpawnRandomPrefabWithCoroutine());
    }
    void Update()
    {
        
    }

    IEnumerator SpawnRandomPrefabWithCoroutine()
    {
        yield return new WaitForSeconds(3f);

        while (!gameOver)
        {
            SpawnRandomprefab();

            

            yield return new WaitForSeconds(1.5f);
        }
    }
    void SpawnRandomprefab()
    {
        int prefabIndex = Random.Range(0, prefabsToSpawn.Length);

        Vector3 spawnPos = new Vector3(Random.Range(leftBound, rightBound), 0, spawnPosZ);

        Instantiate(prefabsToSpawn[prefabIndex], spawnPos, prefabsToSpawn[prefabIndex].transform.rotation);
    }
}
