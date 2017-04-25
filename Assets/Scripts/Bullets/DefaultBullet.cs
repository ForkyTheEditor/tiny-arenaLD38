using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class DefaultBullet : MonoBehaviour
{

    public int damage;
    public float speed = 25.0f;
    public float despawnTime = 5.0f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rb.MovePosition(transform.position + transform.forward * speed * Time.fixedDeltaTime);

        despawnTime -= Time.fixedDeltaTime;
        if (despawnTime <= 0)
        {

            Die();
        }
    }

    private void Die()
    {
        Destroy(this.gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "TerrainFloor")
        {
            if (collision.gameObject.tag == "Enemy")
            {
                collision.gameObject.GetComponent<EnemyStats>().currentHP -= damage;
            }
            Die();
        } 

    }
}
