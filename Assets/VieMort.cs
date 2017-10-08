using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VieMort : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Caisse")
        {
            Debug.Log("Caisse");
            FindObjectOfType<SwitchScene>().mourir();
            Destroy(this.gameObject);
        }
        else if (collision.gameObject.tag == "Sortie")
        {
            Debug.Log("Sortie");
            FindObjectOfType<SwitchScene>().sauver();
            Destroy(this.gameObject);
        }
    }
}
