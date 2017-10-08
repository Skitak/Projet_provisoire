using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CardHover : MonoBehaviour {

	private int points;
	private static String path = "carte ";
	private static String hoverExtension = " hover";
	private static int nCards = 9;
	public Sprite[] cards;
	public Sprite[] hoverCards;
	private int counter;
	SpriteRenderer sr;
	private int solution;
	public String nextScene;

	// Use this for initialization
	void Start () {
		points = PlayerPrefs.GetInt ("Player Score");
		solution = 4;
		//sr = GetComponent<SpriteRenderer> ();
		counter = 2;
		String cardName = path + counter.ToString ();
		Load(cardName + hoverExtension);
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("right")) {
			String cardName = path + counter.ToString ();
			Load(cardName);
			counter = (counter - 1) % (nCards) + 2;
			cardName = path + counter.ToString ();
			Load(cardName + hoverExtension);
		}
		if (Input.GetButtonDown ("left")) {
			String cardName = path + counter.ToString ();
			Load (cardName);
			counter = (counter - 3 + (nCards)) % (nCards) + 2;
			cardName = path + counter.ToString ();
			Load (cardName + hoverExtension);
		}
		if (Input.GetButtonDown ("select")) {
			SelectionCard ();
		}

	}

	private void Load(String path){
		if (path.Contains ("hover")) {
			transform.Find ("Carte " + counter.ToString ()).GetComponent<SpriteRenderer> ().sprite = hoverCards [counter - 2];
		} else {
			transform.Find ("Carte " + counter.ToString ()).GetComponent<SpriteRenderer> ().sprite = cards [counter - 2];
		}
	}
	public void SelectionCard(){
		if (counter == solution) {
			CountPoint (5);
		} else {
			CountPoint(-5);
		}
	}

	public void CountPoint(int addpoints){
		points += addpoints;
		Debug.Log (points);
		PlayerPrefs.SetInt ("Player Score", points);
		SceneManager.LoadScene (nextScene);
	}
}
