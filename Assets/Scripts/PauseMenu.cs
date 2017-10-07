using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {
	public void QuitButton(){
		SceneManager.LoadScene (0);
	}

	public void ContinueButton(){
		
	}
}
