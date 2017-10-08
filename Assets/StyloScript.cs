using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StyloScript : MonoBehaviour {
	private int points;
	public Text pressButton;
	private String[] listInput;
	private int rand;
	public String nextScene;

	// Use this for initialization
	void Start () {
		points = PlayerPrefs.GetInt ("Player Score");
		listInput = new String[] { "up", "down", "left", "right" };
		rand = UnityEngine.Random.Range (0, 4);
		pressButton.text = "Press " + listInput [rand]; 
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown (listInput [rand])) {
			points += 5;
			PlayerPrefs.SetInt ("Player Score", points);
			PlayerPrefs.SetInt ("Theme", 1);
		} else if (!Input.GetButtonDown (listInput [rand])) {
			points -= 5;
			PlayerPrefs.SetInt ("Player Score", points);
			SceneManager.LoadScene (nextScene);
		}
	}
}
