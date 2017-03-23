using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other)
	{

		Debug.Log ("Started to hit");


	}

	void OnCollisionStay(Collision other)
	{

		Debug.Log ("In the collision");

	}


	void OnCollisionExit(Collision other)
	{


		Debug.Log ("Collision got over");
	}

}
