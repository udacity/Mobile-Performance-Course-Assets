using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballBehavior : MonoBehaviour {
	private int selfDestructTime = 500;
	private int expandTime = 50;
	private int countUpResize = 0;
	private int countUpDestroy = 0;

	private float resizeDirection = 1.0f;
	public bool isFirstBall = true;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		countUpResize++;
		this.gameObject.transform.localScale = new Vector3 (this.gameObject.transform.localScale.x + (.001f * resizeDirection), this.gameObject.transform.localScale.y + (.001f * resizeDirection), this.gameObject.transform.localScale.z + (.001f * resizeDirection));

		if (countUpResize >= expandTime) {
			if (resizeDirection > 0) {
				resizeDirection = -1.0f;

			} else {
				resizeDirection = 1.0f;

			}
			countUpResize = 0;
		}

		if (isFirstBall == false) {
			countUpDestroy++;
			if (countUpDestroy >= selfDestructTime) {
				this.gameObject.SetActive(false);
			}
		}
	}
}