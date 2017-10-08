using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour {

	private int points;
	private int phase;
	private int theme;
	public Text psyBox;
	public Text[] heroBox;
	private bool refresh = true;

	// Use this for initialization
	void Start () {
		points = 0;
		phase = 0;
		theme = 0;

	}
	
	// Update is called once per frame
	void Update () {
		if (refresh) {
			UpdateTextBoxes ();
		}
		if(Input.GetButtonDown("up") && (heroBox[0].text != "")){
			ResponseFeedback (0);
		}
		if(Input.GetButtonDown("down") && (heroBox[1].text != "")){
			ResponseFeedback (1);
		}
		if(Input.GetButtonDown("left") && (heroBox[2].text != "")){
			ResponseFeedback (2);
		}
		if(Input.GetButtonDown("right") && (heroBox[3].text != "")){
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
		theme += 1;
		refresh = true;

	}
}
