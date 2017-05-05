using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelController : MonoBehaviour{

    public Button[] buttonObjects;
    // Use this for initialization
    void Start () {
        foreach (var buttonObject in buttonObjects) {
            buttonObject.onClick.AddListener(() => ButtonClicked(buttonObject.name));
        }
	}

    public void ButtonClicked(String ButtonName)
    {
        switch (ButtonName) {

            case "Level1":
                SceneManager.LoadScene("Level1");
                break;

            case "Level2":
                SceneManager.LoadScene("Level2");
                break;

            case "Level3":
                SceneManager.LoadScene("Level3");
                break;

            case "Level4":
                SceneManager.LoadScene("Level4");
                break;

            case "BackButton":
                SceneManager.LoadScene("MainMenu");
                break;

        }
    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKey(KeyCode.Escape)) {
            SceneManager.LoadScene("MainMenu");
        }

    }


}
