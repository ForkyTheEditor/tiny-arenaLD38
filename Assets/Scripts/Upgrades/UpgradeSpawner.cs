using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeSpawner : MonoBehaviour {

    public GameObject[] upgrades;

    public Transform[] positions;

    private System.Random numGen = new System.Random();
    public int minSpawnDelay;
    public int maxSpawnDelay;
    private float timer;


    // Use this for initialization
    void Start () {

        timer = numGen.Next(minSpawnDelay, maxSpawnDelay);

	}
	
	// Update is called once per frame
	void Update () {

        timer -= Time.deltaTime;

        if(timer <= 0)
        {
            print("Upgrade spawned!");
            Instantiate(upgrades[numGen.Next(0, upgrades.Length)], positions[numGen.Next(0, positions.Length)].position, transform.rotation);
            timer = numGen.Next(minSpawnDelay, maxSpawnDelay);
        }

	}
}
