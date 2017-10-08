using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public Vector3 mousePosition;
	public GameObject cursor;
	public GameObject player;
	public static float playerY;
	public static float playerX;
	public Cam cam;

	// Use this for initialization
	void Start () {
		
	}
		
	// Update is called once per frame
	void Update () {
		if (playerY < -12.3863f){
			
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
			player.transform.position += new Vector3 (0, 0.02f, 0);

		if (Input.GetKey (KeyCode.S)) 
			player.transform.position += new Vector3 (0, -0.02f, 0);

		if (Input.GetKey (KeyCode.A)) 
			player.transform.position += new Vector3 (-0.02f, 0, 0);

		if (Input.GetKey (KeyCode.D)) 
			player.transform.position += new Vector3 (0.02f, 0, 0);


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
