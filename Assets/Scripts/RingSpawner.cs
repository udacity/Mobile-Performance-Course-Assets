using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingSpawner : MonoBehaviour {
	public GameObject ring;

	private int spawnerCounter = 0;
	private int spawnerCounterLimit = 2;
	private int spawnCount = 0;

	private List<GameObject> ourObjects;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		spawnerCounter++;

		if (spawnerCounter >= spawnerCounterLimit) {
			spawnCount++;
			spawnerCounter = 0;

			ring = (GameObject)Instantiate (ring, transform.position, transform.rotation);
			ring = (GameObject)Instantiate (ring, transform.position, transform.rotation);
			ring = (GameObject)Instantiate (ring, transform.position, transform.rotation);
			ring = (GameObject)Instantiate (ring, transform.position, transform.rotation);
			ring = (GameObject)Instantiate (ring, transform.position, transform.rotation);
			ring = (GameObject)Instantiate (ring, transform.position, transform.rotation);
			ring = (GameObject)Instantiate (ring, transform.position, transform.rotation);



		}
	}
}
