using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quatMove : MonoBehaviour {

	public GameObject target;
	public Rigidbody rb;

	public GameObject main;
	public GameObject follower;
	public float angle;

	float speed;
	public float multFactor;
	Vector3 prevPos;
	Vector3 currVel;
	public GameObject hand;
	bool targetSet;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();

		StartCoroutine (CalcVelocity ());

		follower.transform.Rotate (new Vector3 (0, angle, 0));

	//t 	target.transform.Rotate (new Vector3 (0, angle, 0));


	}
	
	// Update is called once per frame
	void FixedUpdate () {

		var localVel = transform.InverseTransformDirection (rb.velocity);




		if (OVRInput.Get (OVRInput.Button.Any)) {
			follower.transform.Translate (Vector3.Scale (-transform.forward, new Vector3 (0f, 0f, speed * Time.deltaTime)), Space.Self);
		} else {
			follower.transform.Translate (Vector3.Scale(transform.forward, new Vector3(0f,0f,speed*Time.deltaTime)) , Space.Self);
		}

	//	if (localVel.z > .001) {
			
	//	}

	//	/*if (localVel.z < -.001)*/else {
	//		follower.transform.Translate (Vector3.Scale(-transform.forward, new Vector3(0f,0f,speed*Time.deltaTime*.5f)) , Space.Self);
	//	}


	//follower.transform.Translate (Vector3.Scale(transform.forward, new Vector3(0f,0f,speed*Time.deltaTime*.1f)) , Space.Self);
	//	follower.transform.Translate (Vector3.Scale(-transform.forward, new Vector3(0f,0f,speed*Time.deltaTime*.1f)) , Space.Self);
}

	void Update(){
		print ("TESTSSSS"+Vector3.Distance(hand.transform.position,target.transform.position));
		print("distance: "+Vector3.Distance(hand.transform.position,target.transform.position));
	}

	IEnumerator CalcVelocity(){
		while (Application.isPlaying) {
			prevPos = transform.position;
			yield return new WaitForEndOfFrame ();
			currVel = (prevPos - transform.position) / Time.deltaTime;
	//		Debug.Log ("Curr velocity: " + currVel.magnitude);
		speed = currVel.magnitude*multFactor;


		}
	}

}




//	target.transform.position = new Vector3 (target.transform.position.x, 0, target.transform.position.y);

//speed for orig method
//	speed = speed * Time.deltaTime;

/*t		//Moves target far awaya
		if (targetSet == false) {
			target.transform.Translate (transform.forward * .1f, Space.Self);
		}

		if (target.transform.position.x > 4) {
			targetSet = true;
		}

		if (target.transform.position.z > 4) {
			targetSet = true;
		}

		print (targetSet + " " + target.transform.position.x + " " + target.transform.position.y);

*/
//t	float step = speed*Time.deltaTime;
//t	follower.transform.position = Vector3.MoveTowards (follower.transform.position, target.transform.position, step);
