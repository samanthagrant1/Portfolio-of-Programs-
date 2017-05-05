using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ChangeSpikeDirection : MonoBehaviour {

    public bool moveLeft;
    public Rigidbody2D body;
    public float speed;
	// Use this for initialization
	void Start () {
        if (moveLeft)
        {
            body.velocity = new Vector2(-speed, 0);
        }
        else
        {
            body.velocity = new Vector2(speed, 0);
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (moveLeft)
        {
            body.velocity = new Vector2(-speed, 0);
        }
        else
        {
            body.velocity = new Vector2(speed, 0);
        }


    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "GoOpposite") {
            moveLeft = true;
        }

        if (target.gameObject.tag == "GoOpposite2")
        {
            moveLeft = false;
        }

    }



}
