using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTowardsSc : MonoBehaviour {


	public GameObject target;
	 float speed;
	public float multFactor;
	Vector3 prevPos;
	Vector3 currVel;
	public GameObject hand;

	void Start () {

		StartCoroutine (CalcVelocity ());
	
	}


	void FixedUpdate () {

		float step = speed*Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position, target.transform.position, step);
	//	transform.localPosition += Vector3.forward * Time.deltaTime;
	}

	IEnumerator CalcVelocity(){
		while(Application.isPlaying){
			prevPos = hand.transform.position;
			yield return new WaitForEndOfFrame ();
			currVel = (prevPos - hand.transform.position) / Time.deltaTime;
			speed = currVel.magnitude*multFactor;
	//	Debug.Log ("MAG:      "+currVel.magnitude);
	//		Debug.Log ("currVel" + currVel);
		}
	}
}
