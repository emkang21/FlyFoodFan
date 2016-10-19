using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Fanager : MonoBehaviour {

	public int startLives;
	private int lifeCounter;
	private Text lifeText;
	public GameObject GameOverScreen;

	// Use this for initialization
	void Start () {

		lifeText= GameObject.FindObjectOfType<Text>();
		lifeCounter=startLives;
	
	}
	
	// Update is called once per frame
	void Update () {


		if (lifeCounter <= 0) {

			GameOverScreen.SetActive (true);
		}

		lifeText.text = "x" + lifeCounter;
	
	}


	public void takeLife (){
		lifeCounter--;
	}
}
