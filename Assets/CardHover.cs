using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardHover : MonoBehaviour {

	private static String path = "carte ";
	private static String hoverExtension = " hover";
	private static int nCards = 9;
	public Sprite[] cards;
	public Sprite[] hoverCards;
	private int counter;
	SpriteRenderer sr;

	// Use this for initialization
	void Start () {
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
	}

	private void Load(String path){
		if (path.Contains ("hover")) {
			transform.Find ("Carte " + counter.ToString ()).GetComponent<SpriteRenderer> ().sprite = hoverCards [counter - 2];
		} else {
			transform.Find ("Carte " + counter.ToString ()).GetComponent<SpriteRenderer> ().sprite = cards [counter - 2];
		}
	}
}
