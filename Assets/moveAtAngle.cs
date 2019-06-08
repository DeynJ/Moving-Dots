using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveAtAngle : MonoBehaviour {

	// Use this for initialization
	Vector3 currVel;
	Vector3 prevPos;
	public GameObject hand;


	Vector2 VectorFromAngle (float theta){
		return new Vector2 (Mathf.Cos (theta), Mathf.Sin (theta));
	}

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
	void update(){
	//	transform.Translate(VectorFromAngle(80));

		var rot = Quaternion.AngleAxis (45, Vector3.forward);

		var angle = 45;

		//var dir = Vector3 (0, Mathf.Sin (Mathf.Deg2Rad * angle), Mathf.Cos (Mathf.Deg2Rad * angle));

	//	print ("direction: " + dir);
	}

}
