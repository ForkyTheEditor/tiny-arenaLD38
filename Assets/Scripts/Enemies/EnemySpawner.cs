using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemySpawner : MonoBehaviour {

    public int nrOfEnemies;
    public int maxSpawnedEnemies;
    //public int initialEnemies;
    public Transform[] spawnPositions;

    private System.Random numGen = new System.Random();
    public float spawnDelay;
    private float timer;
    public bool shouldSpawn = true;
    public GameObject[] enemies;

	void Start () {

        timer = spawnDelay;
        shouldSpawn = true;
        nrOfEnemies = 0;
        //for (int i = 0; i < initialEnemies; i++)
        //{
        //    Instantiate(enemies[numGen.Next(0, enemies.Length)], spawnPositions[numGen.Next(0, spawnPositions.Length)].position, transform.rotation);
        //}
	}
	
	void Update () {

        if (shouldSpawn)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                if(enemies[0] != null)
                {
                    Instantiate(enemies[numGen.Next(0, enemies.Length)], spawnPositions[numGen.Next(0, spawnPositions.Length)].position, transform.rotation);
                    timer = spawnDelay;
                    nrOfEnemies++;
                    if (nrOfEnemies >= maxSpawnedEnemies)
                    {
                        shouldSpawn = false;
                    }
                }              
            }
        }
        
	}
}
