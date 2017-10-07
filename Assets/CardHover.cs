using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardHover : MonoBehaviour {
	public Sprite basicSprite;
	public Sprite hoverSprite;
	SpriteRenderer sr;

	// Use this for initialization
	void Start () {
		sr = GetComponent<SpriteRenderer> ();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseOver(){
		sr.sprite = hoverSprite;
	}

	void OnMouseExit(){
		sr.sprite = basicSprite;
	}
}
