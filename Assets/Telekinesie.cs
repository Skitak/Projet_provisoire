using System.Collections;
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

            float horizontalSpeed = 0.5f;
            float h = 0;
            if (!this.transform.parent.name.Equals("Platform_deplacable"))
            {
                //déplacer horizontalement le cube
                 h = horizontalSpeed * Input.GetAxis("Mouse X");

            }
            //déplacer verticalement le cube
            float verticalSpeed = 1.0f;
            float v = verticalSpeed * Input.GetAxis("Mouse Y");
            GetComponent<Transform>().position = new Vector3(transform.position.x + h, transform.position.y + v, transform.position.z);
        }
    }
}
