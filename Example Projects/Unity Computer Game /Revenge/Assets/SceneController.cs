using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

    public GameObject playBtn, howToPlayBtn, optionsBtn, creditsBtn, howToPanel, optionsPanel, creditsPanel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadLevelScene() {
        SceneManager.LoadScene("LoadGame");
    }

    public void OpenHowToPlay() {
        howToPanel.SetActive(true);
    }

    public void CloseHowToPlay() {
        howToPanel.SetActive(false);
    }

    public void OpenOptions() {
        optionsPanel.SetActive(true);
    }

    public void CloseOptions()
    {
        optionsPanel.SetActive(false);
    }

    public void OpenCredits() {
        creditsPanel.SetActive(true);
    }

    public void CloseCredits()
    {
        creditsPanel.SetActive(false);
    }


}
