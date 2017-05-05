using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowScript : MonoBehaviour {

    public Rigidbody2D body;
    public float XForce, YForce;
	// Use this for initialization
	void Start () {
	    if (GameObject.FindGameObjectWithTag("Player").transform.localScale.x < 0) {
	        body.AddForce(new Vector2(-XForce, YForce));
	    }
	    else {
            body.AddForce(new Vector2(XForce, YForce));
        }
		
        body.AddTorque(10);
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), GameObject.FindGameObjectWithTag("Player").GetComponent<Collider2D>());
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "Ground") {
            body.isKinematic = true;
            body.angularVelocity = 0f;
            body.velocity = Vector2.zero;
        }

        GetComponent<Animator>().Play("explode");
        transform.GetChild(0).gameObject.SetActive(true);
    }

    public void DestroyYourself() {
        Destroy(gameObject);
    }



}
