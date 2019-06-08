using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnDial : MonoBehaviour {

	// Use this for initialization
	Vector2 vect;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		vect = OVRInput.Get (OVRInput.Axis2D.SecondaryThumbstick);


		print (transform.eulerAngles.y);
		transform.Rotate (new Vector3 (0f, vect.x , 0f), Space.Self);
	//	print(OVRInput.Get (OVRInput.Axis2D.SecondaryThumbstick));
	//	print (OVRInput.Get (OVRInput.Axis2D.SecondaryThumbstick));
	//	print ("Right: " + OVRInput.Get (OVRInput.Button.SecondaryThumbstickRight));

		//print (OVRInput.Get (OVRInput.Axis2D.SecondaryThumbstick, OVRInput.Controller.RTouch));
		//print (OVRInput.Get (OVRInput.Button.One));

			
		
	}
}
