using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour {

    public int maxHP;
    public int currentHP;

    private void Start()
    {
        currentHP = maxHP;
    }

    private void Update()
    {
        if (currentHP <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(this.gameObject);
    }
}
