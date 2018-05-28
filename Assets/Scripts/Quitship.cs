using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quitship : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// If Q is pressed it gets rid of the object
		if (Input.GetKey(KeyCode.Q))
		{
			gameObject.SetActive(false);
		}
	}
}
