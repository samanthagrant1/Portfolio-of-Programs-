using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider : MonoBehaviour {

    public Transform startPos, endPos;
    public Transform DStartPos, DEndPos, DEndPos2;
    public float speed = 1f;
    public bool collision;
    public bool detected;
    public bool detected2;
    public Rigidbody2D body;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Move();
        ChangeDirection();
        DetectEnemy();
	}

    private void DetectEnemy() {
        Debug.DrawLine(DStartPos.position, DEndPos.position, Color.red);
        Debug.DrawLine(DStartPos.position, DEndPos2.position, Color.red);
        detected = Physics2D.Linecast(DStartPos.position, DEndPos.position, 1 << LayerMask.NameToLayer("Player"));
        detected2 = Physics2D.Linecast(DStartPos.position, DEndPos2.position, 1 << LayerMask.NameToLayer("Player"));

        if (detected || detected2)
        {
            collision = Physics2D.Linecast(startPos.position, endPos.position, 1 << LayerMask.NameToLayer("Ground"));
            if (Mathf.Sign(transform.localScale.x) ==
                Mathf.Sign(GameObject.FindGameObjectWithTag("Player").transform.localScale.x))
            {

                Vector3 temp = transform.localScale;
                if (temp.x == 1f)
                {
                    temp.x = -1f;
                }
                else
                {
                    temp.x = 1f;
                }

                transform.localScale = temp;
                transform.position = Vector2.MoveTowards(transform.position,
                    GameObject.FindGameObjectWithTag("Player").transform.position, 0.3f);
            }
        }



    }

    void FixedUpdate() {
       
    }

    void ChangeDirection()
    {
        collision = Physics2D.Linecast(startPos.position, endPos.position, 1 << LayerMask.NameToLayer("Ground"));

        Debug.DrawLine(startPos.position, endPos.position, Color.green);

        if (!collision)
        {
            Vector3 temp = transform.localScale;
            if (temp.x == 1f)
            {
                temp.x = -1f;
            }
            else
            {
                temp.x = 1f;
            }

            transform.localScale = temp;
        }

    }

    void Move()
    {
        body.velocity = new Vector2(transform.localScale.x, 0) * speed;
    }

    void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "Player")
        {
            Destroy(target.gameObject);
        }
    }
}
