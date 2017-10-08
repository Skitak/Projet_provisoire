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
	public Timer time;
	float timer = 3.0f;
	// Use this for initialization
	void Start () {
		points = PlayerPrefs.GetInt ("Player Score");
		listInput = new String[] { "up", "down", "left", "right" };
		rand = UnityEngine.Random.Range (0, 4);

		pressButton.text = "Press " + listInput [rand]; 
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer < 0)
		{
			points -= 5;
			PlayerPrefs.SetInt ("Player Score", points);
			SceneManager.LoadScene(nextScene);
		}
		if (Input.GetButtonDown (listInput [rand])) {
			Debug.Log (listInput [rand]);
			points += 5;
			Debug.Log (points);
			PlayerPrefs.SetInt ("Player Score", points);
			SceneManager.LoadScene(nextScene);
		} 
	}



}
