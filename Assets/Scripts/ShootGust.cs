using UnityEngine;
using System.Collections;

public class ShootGust : MonoBehaviour {

	public GameObject Gust;
	public AudioSource GustSound;

	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("Fire1")) {
			Instantiate (Gust, transform.position, Gust.transform.rotation);
			GustSound.Play();

		}

	}
}
