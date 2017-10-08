using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Texts : MonoBehaviour {

    public Text tuto1;
    public Text tuto2;
    public Text tuto3;
    public Text timer;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        timer.text = "Temps restant : Inactif";
        if (Input.GetKeyDown(KeyCode.H))
        { 
                tuto1.text = "Pour se déplacer, utiliser <-, ->";
                tuto2.text = "Pour se sauter,la touche UpArrow";
                tuto3.text = "Pour déplacer des objets,souris + clic droit";
            
        }
    }
        
}

