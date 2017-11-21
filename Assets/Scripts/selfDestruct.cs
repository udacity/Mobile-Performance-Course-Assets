using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selfDestruct : MonoBehaviour {
	private int selfDestructTime = 200;
	private int countUp = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		countUp++;

		if (countUp >= selfDestructTime) {
			Destroy (this.gameObject);

		}
	}
}
