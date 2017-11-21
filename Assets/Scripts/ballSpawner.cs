using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballSpawner : MonoBehaviour {
	private int spawnerCounter = 0;
	public int spawnerRate = 10;
	private int spawnCount = 0;

	//private GameObject newBall;

	public List<GameObject> ourBalls = new List<GameObject>();

	private Vector3 generationPosition;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		spawnerCounter++;
		checkPosition ();
		if (spawnerCounter >= spawnerRate) {
			spawnCount++;
			spawnerCounter = 0;



			GameObject newBall = (GameObject)Instantiate (GameObject.Find("Fairy Ball"), generationPosition, transform.rotation) as GameObject;
			newBall.GetComponent<ballBehavior> ().isFirstBall = false;
			ourBalls.Add (newBall);

		}


	}

	void checkPosition() {
		generationPosition = new Vector3 (Random.Range (-3.0f, 3.0f), 2, Random.Range (-3.0f, 3.0f));
		if (ourBalls.Count > 0) {
			for (int i = 0; i < ourBalls.Count; i++) { //Go through all our balls
				GameObject checkBall = GameObject.Find(ourBalls[i].name); //Get their position

				float dist = Vector3.Distance (checkBall.transform.position, generationPosition); //Calculate the distance from our generated point

				if (dist <= 1) { //If we are too close generate a new position
					generationPosition = new Vector3 (Random.Range (-3, 3), 2, Random.Range (-3, 3));
					Debug.Log ("Too Close, Finding new generation spot");
				} 
		
			}
		}
	}
}
