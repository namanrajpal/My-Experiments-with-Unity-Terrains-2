using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonController : MonoBehaviour {

	Animator myanim;
	// Use this for initialization
	void Start () {
		myanim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		float v = Input.GetAxis ("Vertical");

		myanim.SetFloat ("speed",v);


		if (Input.GetKeyDown (KeyCode.B)) {

			myanim.SetTrigger ("doTheMagic");
		}




	}
}
