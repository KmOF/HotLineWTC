using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {
	public Cam cam;

	public void QuitButton(){
		SceneManager.LoadScene ("MainMenu");
	}

	public void ContinueButton(){
		cam.isGameRunning = true;
		cam.resume();
		Debug.Log ("Resume");
	}
}
