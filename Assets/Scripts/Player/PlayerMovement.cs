using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 15.0f;

    //[SerializeField]
    //private float jumpDistance = 5.0f;

   // private bool jump = false;
   // private bool onGround = false;

    private Vector3 finalVelocity;
    private Rigidbody rb;

    //public Transform groundCheck;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {

        //onGround = Physics.Linecast(transform.position, groundCheck.position);

        //if (Input.GetKeyDown(KeyCode.Space) && onGround)
        //{
        //    jump = true;
        //}

        float xInput = Input.GetAxisRaw("Horizontal");
        float zInput = Input.GetAxisRaw("Vertical");

        Vector3 xVelo = Vector3.right * xInput;
        Vector3 zVelo = Vector3.forward * zInput;

        finalVelocity = (xVelo + zVelo).normalized;


    }

    private void FixedUpdate()
    {

        //if (jump)
        //{
        //    rb.AddForce(new Vector3(0, jumpDistance, 0), ForceMode.Impulse);
        //    jump = false;
        //}
        if (!PlayerWeaponSlot.isDead)
        {
            rb.MovePosition(rb.position + finalVelocity * moveSpeed * Time.fixedDeltaTime);
        }
            
    }

}

