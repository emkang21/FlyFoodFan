using UnityEngine;
using System.Collections;

public class GameOverOnTrigger : MonoBehaviour {

	private bool gameOver = false;
	public int fontSize = 200;

	
	// Update is called once per frame
	void OnGUI (){
		if (gameOver) {
			GUILayout.Label ("GAME OVER");
		}
	
	}

	void OnTriggerEnter(){

		gameOver = true;
		
		}
	}


