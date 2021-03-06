using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite_mover : MonoBehaviour {
	private Transform tf; // Creates a variable for our transform component
	public float speed = 0.3f;// Creates a variable for speed and allows developer to change the speed
	// Use this for initialization
	void Start () {
		//Gets the tranform component frm object
		tf = GetComponent<Transform>();
	}

	// Update is called once per frame
	void Update()
	{
		// if up arrow is pressed then it moves up
		if (Input.GetKey(KeyCode.UpArrow))
		{
			tf.position = tf.position + (Vector3.up * speed);
		}
		// if down arrow is pressed then it moves down
		if (Input.GetKey(KeyCode.DownArrow))
		{
			tf.position = tf.position + (Vector3.down * speed);
		}
		// if left arrow is pressed then it moves left
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			tf.position = tf.position + (Vector3.left * speed);
		}
		// if right arrow is pressed then it moves right
		if (Input.GetKey(KeyCode.RightArrow))
		{
			tf.position = tf.position + (Vector3.right * speed);
		}
		// if space is pressed then it moves the sprite back to the center
		if (Input.GetKey(KeyCode.Space))
		{
			tf.position = new Vector3(0, 0, 0);
		}
	}
}
