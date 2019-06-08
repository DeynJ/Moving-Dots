using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class findVelocity : MonoBehaviour {

	// Use this for initialization
	Vector3 currVel;
	Vector3 prevPos;




	void Start () {
		StartCoroutine (CalcVelocity ());
	}

	IEnumerator CalcVelocity(){
		while (Application.isPlaying) {
			prevPos = transform.position;
			yield return new WaitForEndOfFrame ();
			currVel = (prevPos - transform.position) / Time.deltaTime;
			Debug.Log ("Curr vel: " + currVel.magnitude);
		}
	}
	// Update is called once per frame

}
