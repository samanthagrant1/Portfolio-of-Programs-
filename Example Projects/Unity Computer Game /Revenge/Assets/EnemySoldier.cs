using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySoldier : MonoBehaviour {

    public Rigidbody2D body;
    public float XForce, YForce;
	// Use this for initialization
	void Start () {
        Physics2D.IgnoreCollision(GameObject.FindGameObjectWithTag("Player").GetComponent<Collider2D>(), GetComponent<Collider2D>());
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ExplosionLeft() {
       body.AddForce(new Vector2(-XForce,YForce));
       body.AddTorque(20);
    }

    public void ExplosionRight()
    {
        body.AddForce(new Vector2(XForce, YForce));
        body.AddTorque(20);
    }

}
