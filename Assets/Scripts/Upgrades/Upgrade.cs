using System.Collections;
using System.Collections.Generic;
using UnityEngine;
        
public class Upgrade : MonoBehaviour {

    public GameObject newBullet;
    public float rotationSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = new Vector3(transform.position.x, Mathf.Sin(Time.time), transform.position.z);
        transform.Rotate(Vector3.up, rotationSpeed);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponentInChildren<PlayerWeaponSlot>().bullet = newBullet;
            Destroy(this.gameObject); 
        }
    }
}
