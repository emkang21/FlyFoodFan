﻿using UnityEngine;
using System.Collections;

public class FodderAI : MonoBehaviour {

	public float speed = 1.0f;
	public float sinAmplitude = 1.0f;
	public float sinFrequency= 1.0f;
	private float horizontalOffset = 0.0f;
	private float time;

	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {

		time += Time.deltaTime;

		//remove offset from enemy
		transform.position -= horizontalOffset*transform.right;

		//movesenemy forward
		transform.position += transform.forward * speed * Time.deltaTime; 

		//adjust horizontal position by sin wave

		horizontalOffset = Mathf.Sin (time * sinFrequency) * sinAmplitude;

		transform.position += horizontalOffset * transform.right;

	
	}
}
