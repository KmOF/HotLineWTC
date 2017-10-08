using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimation : MonoBehaviour {
	public bool dir;
	public float limit = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (limit >= 10f)
			dir = true;
		else if (limit <= 0)
			dir = false;

		if (dir == true) {
			limit += -0.5f;
			moveDown ();
		} else {
			limit += 0.5f;
			moveUp ();
		}
	}

	void moveUp(){
		transform.position += new Vector3 (0, 0.002f, 0);
	}

	void moveDown(){
		transform.position += new Vector3 (0, -0.002f, 0);
	}
}
