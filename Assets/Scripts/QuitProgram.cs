using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitProgram : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Quits the application
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Debug.Log("You Quit the Program");
			Application.Quit();
		}
	}
}
