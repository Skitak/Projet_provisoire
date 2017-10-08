using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextManager : MonoBehaviour {

	private int points;
	public int phase;
	public int theme;
	public Text psyBox;
	public Text[] heroBox;
	private bool refresh = true;
	public String nextScene;

	// Use this for initialization
	void Start () {
		points = 50;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (refresh) {
			UpdateTextBoxes ();
		}

		if (Input.GetButtonDown ("up") && (heroBox [0].text != "")) {
			ResponseFeedback (0);
		}
		if (Input.GetButtonDown ("down") && (heroBox [1].text != "")) {
			ResponseFeedback (1);
		}
		if (Input.GetButtonDown ("left") && (heroBox [2].text != "")) {
			ResponseFeedback (2);
		}
		if (Input.GetButtonDown ("right") && (heroBox [3].text != "")) {
			ResponseFeedback (3);
		}
	}	

	private void UpdateTextBoxes(){
		Debug.Log ("phase :" + phase);
		Debug.Log ("theme : " + theme);
		psyBox.text = DialogueList.GetText (phase, theme, 0, 0);

		for(int i = 0; i < 4; i++){
			heroBox[i].text = DialogueList.GetText (phase, theme, 1, i);
		}
		refresh = false;
	}

	private void ResponseFeedback(int heroBoxId){
		switch (phase) {
		case 0: 
			UpdateStory (3);
			break;
		case 1:
			UpdateStory (3);
			break;
		case 2:
			UpdateStory (4);
			break;
		case 3:
			UpdateStory (2);
			break;
		}

	}

	private void UpdateStory(int nbTheme){
		if (theme < nbTheme) {
			++theme;
		} else if (theme == nbTheme) {
			PlayerPrefs.SetInt ("Player Score", points);
			SceneManager.LoadScene (nextScene);
		} else {
			++phase;
		}
		refresh = true;
	}
}
