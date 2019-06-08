using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllerAngle : MonoBehaviour {

	public GameObject movingParticles;
	public GameObject c1;
	public GameObject c2;

	bool setAngle;

	Vector3 baseline;
	Vector3 currAngle;
	float offPath;
	Vector3 partStart;
	public float offSet;
	float angle;
	public float multFactor;


	void Start () {
		StartCoroutine (waitSecs ());
		setAngle = false;
	}
	
	// Update is called once per frame
	void Update () {



		currAngle = OVRInput.GetLocalControllerPosition (OVRInput.Controller.RTouch) - OVRInput.GetLocalControllerPosition (OVRInput.Controller.LTouch);
		angle = Vector3.Angle (baseline, currAngle);
		offPath = angle - offSet;
		print ("Angle between Base and curr: "+angle+ " offset angle: "+offPath);




	

		 
		if(OVRInput.Get(OVRInput.Button.One)){
			baseline = OVRInput.GetLocalControllerPosition (OVRInput.Controller.RTouch) - OVRInput.GetLocalControllerPosition (OVRInput.Controller.LTouch);
			print ("NEW BASELINE: " + baseline);
			movingParticles.transform.position = c2.transform.position;
			print ("NEW PART START: " + movingParticles.transform.position);
			setAngle = false;
		}


		if (OVRInput.Get (OVRInput.Button.Two)) {
			print ("BUTTON TWO**************************");
			if (!setAngle) {
				movingParticles.transform.eulerAngles = new Vector3 (0f, angle+offSet, 0f);
			//	movingParticles.transform.eulerAngles = new Vector3 (0f, offSet, 0f);
				//movingParticles.transform.Rotate (new Vector3 (0, offPath, 0f));
			//	setAngle = true;
				print ("ROTATED YAY _______________");
			}
		//	currPath = currAngle;
		}


	 movingParticles.transform.Translate(OVRInput.GetLocalControllerVelocity(OVRInput.Controller.RTouch).x*multFactor,0f,OVRInput.GetLocalControllerVelocity(OVRInput.Controller.RTouch).z*multFactor);
		// rotate to offset angle
		//transform.forward 

	/*	if (setAngle == false) {
			movingParticles.transform.Rotate (new Vector3 (0f, angle, 0f));
			setAngle = true;
		}
*/


		//	movingParticles.transform.Translate(0f,OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch).y,0f);

	//	print ("vel: "+OVRInput.GetLocalControllerVelocity (OVRInput.Controller.RTouch));
	//	baseline = c1.transform.position - c2.transform.position;

	//	print ("c1: "+c1.transform.position);
	//	print ("c2: " + c2.transform.position);
	//	print(baseline);



	//	print (c1.transform.position - c2.transform.position);
	}

	IEnumerator waitSecs(){
		yield return new WaitForSecondsRealtime (3);
		print ("I WAITED");
		baseline = OVRInput.GetLocalControllerPosition (OVRInput.Controller.RTouch) - OVRInput.GetLocalControllerPosition (OVRInput.Controller.LTouch);

	/*		GameObject anchorCube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
		anchorCube1.transform.localScale += new Vector3 (-.8f, -.8f, -.8f);
		anchorCube1.transform.position = OVRInput.GetLocalControllerPosition (OVRInput.Controller.RTouch);

		GameObject anchorCube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
		anchorCube2.transform.localScale += new Vector3 (-.8f, -.8f, -.8f);
		anchorCube2.transform.position = OVRInput.GetLocalControllerPosition (OVRInput.Controller.LTouch);
*/

		print (baseline);
		
	}
}
