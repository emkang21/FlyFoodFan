using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FlySpawningScript : MonoBehaviour {

	public GameObject objectToSpawn;
	public float spawnDelay  = 1.0f;
	private Fanager fan;

	// Use this for initialization
	void Start () {
		Invoke ("Spawn", spawnDelay);
		fan = FindObjectOfType<Fanager>();
	
	}
	

	void Spawn () {

		Instantiate (objectToSpawn, transform.position, transform.rotation);
		Invoke ("Spawn", spawnDelay);
	
	}

	void OnTriggerEnter(Collider other){
		if (other.name == "food1"){   //or whichever your food game object is called
			Destroy (gameObject);
			fan.takeLife();

		}
	}

}
