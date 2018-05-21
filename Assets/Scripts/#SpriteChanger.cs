using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour {
//Declare our variables
	public SpriteRenderer theRenderer;

	// Use this for initialization
	void Start () {
		//Change the "color" value of our SpriteRenderer Component to green
		theRenderer.color = Color.green;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
