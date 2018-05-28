using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {
	private Sprite_mover move; // Creates a variable for sprite mover
	// Use this for initialization
	void Start () {
		//Loads the sprite mover component
		move = GetComponent<Sprite_mover>();
	}
	
	// Update is called once per frame
	void Update () {

		//Allows the user to pause and Unpause 
		if (Input.GetKeyDown(KeyCode.P))
		{
			// Pauses
			if (move.enabled == true)
			{
				Debug.Log("Pause");
				move.enabled = false;
			}
			// Unpauses
			else if (move.enabled == false)
			{
				Debug.Log("UnPause");
				move.enabled = true;
			}
		}
	}
}
