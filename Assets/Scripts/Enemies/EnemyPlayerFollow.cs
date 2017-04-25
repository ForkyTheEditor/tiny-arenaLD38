using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
    [RequireComponent(typeof(NavMeshAgent))]
public class EnemyPlayerFollow : MonoBehaviour {

    private GameObject target;
    private NavMeshAgent navMesh;

	// Use this for initialization
	void Start () {

        target = GameObject.FindGameObjectWithTag("Player");
        navMesh = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        navMesh.SetDestination(target.transform.position);
	}
}
