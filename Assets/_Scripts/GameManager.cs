using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public Transform player;
	public GameObject bullet;
	enum Direction { NORTH,SOUTH,EAST,WEST

		}

	Direction dir;


	enum GameState { STARTING,PLAYING,GAMEOVER

		} 


	GameState GS;

	// Use this for initialization
	void Start () {
		dir = Direction.EAST;
		GS = GameState.STARTING;
		//InvokeRepeating ("shoot", 3f, 1.5f);
		//Invoke("shoot",3f);
	}
	
	// Update is called once per frame
	void Update () {


		int value =1;


		switch (GS) {

		case GameState.STARTING:

			//Debug.Log ("GameStarted");
			GS = GameState.PLAYING;
			break;

		case GameState.PLAYING:

			//Debug.Log ("Playing");

			if (Input.GetKeyUp (KeyCode.G)) {
				GS = GameState.GAMEOVER;
			}
			break;
					
		case GameState.GAMEOVER:

			//Debug.Log ("Game Over");
			break;
		default:

			break;

		}



		if (value == 1) {

		} else {
			if (value == 2) {


			} else {
				if (value == 3) {

				}

			}

		}







	}


	public void GameOver()
	{

		Debug.Log ("I am clicked");
	}
		

}
