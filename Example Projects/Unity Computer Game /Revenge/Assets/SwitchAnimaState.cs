using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchAnimaState : MonoBehaviour {

    public Animator anim;
	// Use this for initialization
	void Start () {
        Scene scene = SceneManager.GetActiveScene();
        String sceneName = scene.name; // name of scene
	    if (sceneName == "Level2") {
            gameObject.GetComponent<Animator>().Play("idle2");
	    }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
