using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_With_Shift : MonoBehaviour {
	private Transform tf; // Creates a variable for our transform component
	private float speed = 1.0f;// creates a variable to chane the movement speed with
	// Use this for initialization
	void Start () {
		tf = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		//if left or right shift is pressed and a key it moves the sprite that direction one unit
		if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.LeftShift))
		{
			//If up arrow move up one unit
			if (Input.GetKeyDown(KeyCode.UpArrow))
			{
				tf.position = tf.position + (Vector3.up * speed);
			}
			//if down arrow move down one unit
			else if (Input.GetKeyDown(KeyCode.DownArrow))
			{
				tf.position = tf.position + (Vector3.down * speed);
			}
			//if left arrow move left one unit
			else if (Input.GetKeyDown(KeyCode.LeftArrow))
			{
				tf.position = tf.position + (Vector3.left * speed);
			}
			//if right arrow move right one unit
			else if (Input.GetKeyDown(KeyCode.RightArrow))
			{
				tf.position = tf.position + (Vector3.right * speed);
			}
		}
	}
}
