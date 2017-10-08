using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer_lvl3 : MonoBehaviour {
    public Text text;

    // Use this for initialization
    void Start () {
		
	}

    float timeLeft = 360.0f;
    // Update is called once per frame
    void Update()
    {
        text.text = "Temps restant:" + timeLeft;
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            SceneManager.LoadScene("Level_3");
        }

    }
}
