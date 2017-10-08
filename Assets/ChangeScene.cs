using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	public float tempsPassage = 3f;
	public string nextScene;

	void Update () {
		tempsPassage -= Time.deltaTime;
		if (tempsPassage < 0)
			SceneManager.LoadScene (nextScene);
	}
}
