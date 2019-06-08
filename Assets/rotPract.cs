using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotPract : MonoBehaviour {

	public GameObject cube;

	// Use this for initialization
	void Start () {
		transform.RotateAround (cube.transform.position, Vector3.up, 20f);
	}
	
	// Update is called once per frame
	void Update () {

	}
}
