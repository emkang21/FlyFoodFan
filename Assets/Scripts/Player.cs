using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed = 10.0f;


	// Use this for initialization


	void Start () {

	
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"), 0.0f) * speed * Time.deltaTime;
		
	}
}
