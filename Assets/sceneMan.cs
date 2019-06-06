using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneMan : MonoBehaviour {

	// Use this for initialization
	public void NewGameBtn(string newGameLevel){

		SceneManager.LoadScene (newGameLevel);
	}
}
