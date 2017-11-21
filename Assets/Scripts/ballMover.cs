using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMover : MonoBehaviour {
	public float thrust = 10.0f;
	private Vector3 forceDirection;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		moveBalls ();
	}
		


	void moveBalls() {

		for (int i = 0; i < GameObject.Find ("Ball Spawner").GetComponent<ballSpawner> ().ourBalls.Count; i++) {

			forceDirection = new Vector3 (Random.Range (-1.0f, 1.0f), Random.Range (-1.0f, 1.0f), Random.Range (-1.0f, 1.0f));

			GameObject.Find ("Ball Spawner").GetComponent<ballSpawner> ().ourBalls [i].GetComponent<Rigidbody> ().AddForce (forceDirection*thrust);
		}
	}
}
