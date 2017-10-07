using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telekinesie : MonoBehaviour {

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
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color(0,0,0,255);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);
    }
}
