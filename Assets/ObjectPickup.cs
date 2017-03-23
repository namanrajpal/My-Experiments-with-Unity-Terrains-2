using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPickup : MonoBehaviour {


	Collider h;

	RaycastHit hit;


	bool isGrabbed;

	// Use this for initialization
	void Start () {
		

		isGrabbed = false;
	}


	
	// Update is called once per frame
	void Update () {


		Debug.DrawRay (gameObject.transform.position, gameObject.transform.forward * 5f, Color.red, 1f);

		if(Physics.Raycast(gameObject.transform.position,gameObject.transform.forward,out hit,5f))
			{

			if (hit.collider.tag == "grenades") {


				if (Input.GetKeyDown (KeyCode.P) && isGrabbed == false) {
					hit.collider.attachedRigidbody.isKinematic = true;
					hit.collider.gameObject.transform.SetParent (gameObject.transform);
					isGrabbed = true;
				} else {


					if (Input.GetKeyDown (KeyCode.P) && isGrabbed == true) {

						hit.collider.attachedRigidbody.isKinematic = false;

						hit.collider.gameObject.transform.SetParent (null);
						hit.collider.attachedRigidbody.useGravity= true;
						isGrabbed = false;
					}

					if(Input.GetKeyDown(KeyCode.T)&& isGrabbed == true)
						{
						hit.collider.attachedRigidbody.isKinematic = false;
						hit.collider.gameObject.transform.SetParent (null);
						isGrabbed = false;
						hit.collider.attachedRigidbody.useGravity= true;
						hit.collider.attachedRigidbody.AddForce (gameObject.transform.forward * 40f,ForceMode.Impulse);


						}

					if(Input.GetKeyDown(KeyCode.R)&& isGrabbed == true)
					{
						hit.collider.attachedRigidbody.isKinematic = false;
						hit.collider.attachedRigidbody.useGravity= false;
						hit.collider.attachedRigidbody.AddTorque(Vector3.down*40f);
						isGrabbed = false;

					}



				
				}


			}





			}



	}
}
