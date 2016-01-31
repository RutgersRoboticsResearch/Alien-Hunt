using UnityEngine;
using System.Collections;

using System;

using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Utility;
using UnityEngine.UI;
using Random = UnityEngine.Random;
public class BullsEye : MonoBehaviour {
	// left and right marks
	public Transform left;
	public Transform right;


	// speed
	public float speed = 1.0f;
	
	// current direction (false means to the left, true means to the right)
	bool dir = false;

	void OnCollisionEnter(Collision c) {
		GameObject.Find("Main Camera").GetComponent<Counts>().count ++; 
		Destroy(gameObject);
	}


	// Update is called once per frame
	void Update () {
		if (dir) {
			// go closer to the right one
			transform.position = Vector3.MoveTowards(transform.position,
			                                         right.position,
			                                         Time.deltaTime * speed);
			
			// reached it?
			if (transform.position == right.position)
				dir = !dir; // go to opposite direction next time
		} else {
			// go closer to the left one
			transform.position = Vector3.MoveTowards(transform.position,
			                                         left.position,
			                                         Time.deltaTime * speed);
			
			// reached it?
			if (transform.position == left.position)
				dir = !dir; // go to opposite direction next time
		}
	}
}