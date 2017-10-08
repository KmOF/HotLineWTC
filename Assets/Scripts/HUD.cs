using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour {
	public GameObject Win;
	public GameObject Lose;

	// Use this for initialization
	void Start () {
		Win.SetActive(false);
		Lose.SetActive(false);
	}

	public void win(){
		Win.SetActive(true);
	}

	public void lose(){
		Lose.SetActive(true);
	}
}
