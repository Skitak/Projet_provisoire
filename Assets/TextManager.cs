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
		if (phase == 0) {
			points = 50;		
		} else {
			points = PlayerPrefs.GetInt ("Player Score");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		if (refresh) {
			UpdateTextBoxes ();
		}

		if (Input.GetButtonDown ("up") && (heroBox [0].text != "")) {
            points += DialogueList.GetScore(phase, theme, 0);
			ResponseFeedback (0);
		}
		if (Input.GetButtonDown ("down") && (heroBox [1].text != "")) {
            points += DialogueList.GetScore(phase, theme, 1);
            ResponseFeedback (1);
		}
		if (Input.GetButtonDown ("left") && (heroBox [2].text != "")) {
            points += DialogueList.GetScore(phase, theme, 2);
            ResponseFeedback (2);
		}
		if (Input.GetButtonDown ("right") && (heroBox [3].text != "")) {
            points += DialogueList.GetScore(phase, theme, 3);
            ResponseFeedback (3);
		}
	}	

	private void UpdateTextBoxes(){
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
			UpdateStory (0);
			break;
		case 3:
			UpdateStory (1);
			break;
		case 4: 
			UpdateStory (1);
			break;
		case 5:
			UpdateStory (1);
			break;
		}

	}

	private void UpdateStory(int nbTheme){
		Debug.Log ("points : " + points);
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
