using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour {
	
	public GameObject PauseMenu;
	public bool isGameRunning;

	// Use this for initialization
	void Start () {
		PauseMenu.SetActive(false);
		isGameRunning = true;
	}
	
	// Update is called once per frame
	void Update () {
		transform.localPosition = new Vector3 (Player.playerX, Player.playerY, -10f);
		pauseState ();
	}

	void pauseState(){
		if (Input.GetKey (KeyCode.P)) {
			if (isGameRunning == true) {
				PauseMenu.SetActive (true);
				isGameRunning = false;
			} else {
				PauseMenu.SetActive (false);
				isGameRunning = true;
			}
		}


	}

	public void resume(){
		if (isGameRunning == true) {
			PauseMenu.SetActive (false);
		}
	}
}
