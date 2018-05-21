using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChange : MonoBehaviour {
	// Declare our variables
	private SpriteRenderer theRenderer; // variable for our renderer
	public Color spriteColor; // variable for our color

	// Use this for initialization
	void Start () {
		//Load the SpriteRenderer component from the same object this is on.
		theRenderer = gameObject.GetComponent<SpriteRenderer>();
		//Change the color from our color so that the alpha is 1
		spriteColor.a = 1.0f;
		//As long as theRendere has been set
		if (theRenderer != null) {
			// change the "color" value of the SpriteRenderer componet to our new color
			theRenderer.color = spriteColor;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
