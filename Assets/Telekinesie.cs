﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telekinesie : MonoBehaviour {

    private bool deplace = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            this.deplace = true;
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color(0,0,0,255);

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            this.deplace = false;
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);

        }
            
    }
    void OnMouseDrag()
    {
        if (deplace)
        {
            Rigidbody2D rgb2D = GetComponent<Rigidbody2D>();
            rgb2D.gravityScale = 0;
            Vector3 souris = Input.mousePosition; 
            souris = GetComponent<Transform>().InverseTransformPoint(Camera.main.ScreenToWorldPoint(souris));

            float h = 0;
            if (!this.transform.parent.name.Equals("Platform_deplacable"))
            {
                //déplacer horizontalement le cube
                 h =  souris.x;

            }
            //déplacer verticalement le cube
            float v =  souris.y;
            
            Vector2 vect = new Vector2(h,  v);
            rgb2D.MovePosition(rgb2D.position + vect);
            
        }
    }
    private void OnMouseUpAsButton()
    {
        GetComponent<Rigidbody2D>().gravityScale = 3;
    }
}

