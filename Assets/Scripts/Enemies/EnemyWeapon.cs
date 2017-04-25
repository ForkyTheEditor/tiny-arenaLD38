using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : MonoBehaviour {

    public int damage;
    public int minDelay;
    public int maxDelay;
    private float shootDelay;
    private float timer;
    private GameObject player;
    public GameObject bullet;
    private System.Random numGen = new System.Random();

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        shootDelay = numGen.Next(minDelay, maxDelay);
        timer = shootDelay;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            Instantiate(bullet, transform.position, transform.rotation);
            timer = shootDelay;
        }
        transform.LookAt(player.transform.position);
    }

}
