using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnCirc : MonoBehaviour {

	public GameObject obj;

	// Use this for initialization
	void Start () {
		

		float radius = 8f;

		for (int i = 0; i < 36; i++) {
			float angle = i * Mathf.PI * 2f / 36;
			Vector3 newPos = new Vector3 (Mathf.Cos (angle) * radius, 1f, Mathf.Sin (angle) * radius);
			GameObject targ = Instantiate (obj, newPos, Quaternion.identity);

		}
	}
	
	// Update is called once per frame
	void Update () {


	}
}
