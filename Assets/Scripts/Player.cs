using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public Vector3 mousePosition;
	public GameObject cursor;
	public GameObject player;
	public GameObject Win;
	public GameObject Lose;
	public static float playerY;
	public static float playerX;
	public Cam cam;

	// Use this for initialization
	void Start () {
		Win.SetActive(false);
		Lose.SetActive(false);
	}
		
	// Update is called once per frame
	void Update () {
		if (playerY < -12.3863f){
			Win.SetActive(true);
		}
		else if (cam.isGameRunning == true) {
			moveCursor ();
			movePlayer ();
		}
	}

	void movePlayer(){
		faceCursor ();

		mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		if (Input.GetKey (KeyCode.W)) 
			player.transform.position += new Vector3 (0, 0.05f, 0);

		if (Input.GetKey (KeyCode.S)) 
			player.transform.position += new Vector3 (0, -0.05f, 0);

		if (Input.GetKey (KeyCode.A)) 
			player.transform.position += new Vector3 (-0.05f, 0, 0);

		if (Input.GetKey (KeyCode.D)) 
			player.transform.position += new Vector3 (0.05f, 0, 0);


		playerX = player.transform.position.x;
		playerY = player.transform.position.y;
	}

	void faceCursor(){
		mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);

		Vector2 direction = new Vector2 (
            mousePosition.x - transform.position.x,
            mousePosition.y - transform.position.y
        );

		transform.up = direction;
	}

	void moveCursor(){
		mousePosition = Input.mousePosition;
		mousePosition = Camera.main.ScreenToWorldPoint (mousePosition);

		cursor.transform.localPosition = new Vector2 (mousePosition.x, mousePosition.y);
	}
}
