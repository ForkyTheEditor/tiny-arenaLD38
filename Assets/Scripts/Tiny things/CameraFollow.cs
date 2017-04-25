using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField]
    private GameObject playerGO;

    private Vector3 offset;


    private void Start()
    {
        playerGO = GameObject.FindGameObjectWithTag("Player");
        offset = playerGO.transform.position - transform.position;
    }

    private void FixedUpdate()
    {

        transform.position = new Vector3(playerGO.transform.position.x - offset.x, transform.position.y, playerGO.transform.position.z - offset.z);

    }
}
