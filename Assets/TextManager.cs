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
		phase = 1;
		theme = 2;

	}
	
	// Update is called once per frame
	void Update () {
		if (refresh) {
			UpdateTextBoxes ();
		}
	}	

	private void UpdateTextBoxes(){
		psyBox.text = DialogueList.GetText (phase, theme, 0, 0);

		for(int i = 0; i < 4; i++){
			heroBox[i].text = DialogueList.GetText (phase, theme, 1, i);
		}
		refresh = false;
	}
}
