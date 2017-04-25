using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
        [RequireComponent(typeof(EnemySpawner))]
public class RoundSpawning : MonoBehaviour {


    public static int roundNumber;
    public Text roundText;
    public float fadeTimer;
    private float timer;
    private float roundStartTimer = 3f;
    private EnemySpawner spawner;
    private bool newRoundStart = false;

	// Use this for initialization
	void Start () {

        timer = fadeTimer;
        roundNumber = 1;
        roundText.text = "Round " + roundNumber;
        spawner = this.GetComponent<EnemySpawner>();
	}

    // Update is called once per frame
    void Update() {

        timer -= Time.deltaTime;
        roundStartTimer -= Time.deltaTime;

        if (timer <= 0)
        {
            roundText.text = "";
        }

        if (roundStartTimer <= 0)
        {
            if (GameObject.FindGameObjectWithTag("Enemy") == null)
            {
                newRoundStart = true;
            }
        }


        if (newRoundStart)
        {
            roundNumber++;
            roundText.text = "Round " + roundNumber;
            spawner.maxSpawnedEnemies = (roundNumber * spawner.maxSpawnedEnemies)/2 + 2;
            newRoundStart = false;
            PlayerStats.currentHP = 100;
            spawner.shouldSpawn = true;
            timer = fadeTimer;
            roundStartTimer = 3f;
            spawner.nrOfEnemies = 0;
        }

	}
}
