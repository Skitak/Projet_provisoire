using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text text;

	// Use this for initialization
	void Start () {
		
	}
    float timeLeft = 200.0f;
    // Update is called once per frame
    void Update () {
        text.text = "time Left:" + timeLeft;
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            SceneManager.LoadScene("Level_3");
        }

    }
}
