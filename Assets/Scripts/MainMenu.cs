using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
	public void StartButton_OnClick(){
		SceneManager.LoadScene (1);
	}

	public void QuitButton_OnClick(){
		Application.Quit();
	}
}
