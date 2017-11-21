using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whizzBallMovement : MonoBehaviour {
	public int counter = 0;
	public int moveRate = 100;

	private Vector3 moveToLocation;
	private float gravityFactor = 1.0f;
	// Use this for initialization
	void Start () {
		moveToLocation = new Vector3 (Random.Range (-2.0f, 2.0f), Random.Range (1.0f, 2.0f), Random.Range (-2.0f, 2.0f));
	}
	void FixedUpdate() {
		counter++;
		this.GetComponent<Rigidbody>().AddForce((moveToLocation - transform.position).normalized * this.GetComponent<Rigidbody>().mass * gravityFactor / (moveToLocation - transform.position).sqrMagnitude);

		if (counter >= moveRate) {
			moveToLocation = new Vector3 (Random.Range (-2.0f, 2.0f), Random.Range (0.0f, 2.0f), Random.Range (-2.0f, 2.0f));
			counter = 0;

		}
	}

	// Update is called once per frame
	void Update () {
		
		
	}
}
