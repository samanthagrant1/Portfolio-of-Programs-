using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpposeForces : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Enemy") {
            if (target.gameObject.transform.localScale.x < 0) {
                target.gameObject.SendMessage("ExplosionRight");//Note the scale is default to right
            }
            else {
                target.gameObject.SendMessage("ExplosionLeft");
            }
            
        }
    }
}
