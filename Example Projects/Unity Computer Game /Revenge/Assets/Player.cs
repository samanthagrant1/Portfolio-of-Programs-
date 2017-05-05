using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Rigidbody2D body;
    public bool onGround;
    public Animator anim;
    public GameObject grenade;
    public GameObject grenadeSpawn;
    public float moveForce , jumpForce, maxVelocity;



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Movement();
    }

    void FixedUpdate()
    {
        
    }

    void Movement() {

        float forceX = 0f;
        float forceY = 0f;

        float vel = Mathf.Abs(body.velocity.x);

        float h = Input.GetAxisRaw("Horizontal");

        if (h > 0)
        {
            if (vel < maxVelocity)
            {
                if (onGround)
                {
                    forceX = moveForce;
                }
                else
                {
                    forceX = moveForce * 1.1f;
                }
            }

            Vector3 scale = transform.localScale;
            scale.x = 1f;
            transform.localScale = scale;

            anim.SetBool("Run", true);

        }
        else if (h < 0) {

           

            if (vel < maxVelocity)
            {
                if (onGround)
                {
                    forceX = -moveForce;
                }
                else
                {
                    forceX = -moveForce * 1.1f;
                }
            }

            Vector3 scale = transform.localScale;
            scale.x = -1f;
            transform.localScale = scale;

            anim.SetBool("Run", true);

        }
        else if (h == 0)
        {
            anim.SetBool("Run", false);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if (onGround)
            {
                anim.SetBool("Jump", true);
                anim.SetBool("Run", false);
                anim.SetBool("OnGround", false);
                onGround = false;
                forceX = moveForce;
                forceY = jumpForce;
            }
        }

        //Shoot Code
        if (Input.GetKeyDown(KeyCode.F)) {
            anim.SetBool("ShootRun", true);
            anim.SetBool("Shoot", true);
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            anim.SetBool("ShootRun", false);
            anim.SetBool("Shoot", false);
        }

        //Throw Code
        if (Input.GetKey(KeyCode.G))
        {
            anim.SetBool("Throw", true);
            anim.SetBool("ThrowRun", true);
           
        }
        //if (Input.GetKeyUp(KeyCode.G))
        //{
        //    anim.SetBool("Throw", false);
        //}


        body.AddForce(new Vector2(forceX, forceY));
    }

    public void SetThrowFalse() {
        anim.SetBool("Throw", false);
        anim.SetBool("ThrowRun", false);
    }

    public void ThrowGrenade() {
        Instantiate(grenade, grenadeSpawn.transform.position, Quaternion.identity);
    }

    void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "Ground")
        {
            onGround = true;
            anim.SetBool("Jump", false);
            anim.SetBool("Run", true);
            anim.SetBool("OnGround", true);
        }
    }

    void OnTriggerExit2D(Collider2D target)
    {

        if (target.gameObject.tag == "Spike")
        {
            Debug.Log("Hit by spike.");
        }
    }

    void OnCollisionExit2D(Collision2D target)
    {
        if (target.gameObject.tag == "Ground")
        {
            onGround = true;
            anim.SetBool("Jump", false); 
        }
    }
}
