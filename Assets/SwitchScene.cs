using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour {

    public int nbPersonne;
    public string sceneSuivante;
    private int nbVictime =0 ;
    private int nbSauve = 0;
    private int score;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(sceneSuivante);
        }
    }

    private bool finDeLevel()
    {
        return nbVictime + nbSauve == nbPersonne;
    }
    public void sauver()
    {
        score += 1;
        nbSauve += 1;
        if(finDeLevel())
            SceneManager.LoadScene(sceneSuivante);
    }

    public void mourir()
    {
        score -= 1;
        nbVictime += 1;
        if (finDeLevel())
			SceneManager.LoadScene(sceneSuivante);
    }
}
