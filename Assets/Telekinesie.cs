using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Telekinesie : MonoBehaviour {

    private bool deplace = false;
    private Vector3 initial;
    private Rigidbody2D rgb2D;
	// Use this for initialization
	void Start () {
        initial = transform.position;
        rgb2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

	}
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            this.deplace = true;
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255,0,0,255);

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            this.deplace = false;
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);

        }
        if (transform.tag.Equals("Caisse") || transform.tag.Equals("Victim"))
        {
            rgb2D.gravityScale = 3;
        }
        initial = transform.position;

    }
    void OnMouseDrag()
    {
        if (deplace)
        {
           // Rigidbody2D rgb2D = GetComponent<Rigidbody2D>();

            Vector3 souris = Input.mousePosition; 
            souris = GetComponent<Transform>().InverseTransformPoint(Camera.main.ScreenToWorldPoint(souris));

            float h = 0;
            float v = souris.y;

           // if (rgb2D != null)
            //{
                rgb2D.gravityScale = 0;
            /* if (this.transform.name.Equals("Platform"))
             {
                 Debug.Log("Platform");
                 h = 0;
             }
             else
             {
                 h = souris.x;
             }*/
            if (!this.transform.name.Equals("Platform"))
            {
                h = souris.x;
            }
                if (Mathf.Abs(initial.x - rgb2D.position.x+h)>4)
                {
                    h = 0;
                }
                if (Mathf.Abs(initial.y - rgb2D.position.y + v) > 4)
                {
                    v = 0;
                }

                Vector2 vect = new Vector2(h, v);
                
                rgb2D.MovePosition(rgb2D.position + vect);

        //}
          /*  else //cas des plateforms
            {
                Vector3 vect = new Vector3(0, v, 0);
                GetComponentInParent<Transform>().position = GetComponentInParent<Transform>().position + vect;
            }*/

        }
    }
    private void OnMouseUpAsButton()
    {
        Rigidbody2D rgb2D = GetComponent<Rigidbody2D>();
        if(transform.tag.Equals("Caisse") || transform.tag.Equals("Victim"))
        {
            rgb2D.gravityScale = 3;
        }
        initial = transform.position;

    }
}

