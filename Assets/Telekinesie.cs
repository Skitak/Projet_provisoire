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
        if (other.gameObject.tag == "Caisse")
        {
            other.gameObject.transform.position = new Vector3(other.gameObject.transform.position.x, other.gameObject.transform.position.y + 5, other.gameObject.transform.position.z);
        }
    }
}
