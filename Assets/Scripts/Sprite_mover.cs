using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
	float myVector1 = 3.0f; //A one-dimensional vector is just a float
	Debug.Log(Mathf.Abs(myVector1)); //Output its magnitude
	Debug.Log(Mathf.sign(myVector1)); //Output its direction (1 or -1)
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
