using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectTrigger : MonoBehaviour {


	public GameObject player;
	public Light light;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	

		if(Input.GetKeyDown(KeyCode.E))
			{
				//Explode();
			}

	}


	void Explode()
	{
		Collider[] colliders = Physics.OverlapSphere (transform.position, 5f);

		for (int i = 0; i < colliders.Length; i++) {
			colliders [i].attachedRigidbody.AddForce (transform.forward * 40f, ForceMode.Impulse);
		}

	}

	void OnTriggerEnter(Collider other)
	{

		Debug.Log (other.tag);
		if (other.tag == player.tag) {

			light.intensity = 4f;
		}


	}



	void OnTriggerStay(Collider other)
	{
		Debug.Log ("In the collision with Trigger");
	}

	void OnTriggerExit(Collider other)
	{
		Debug.Log ("Collision got over with Trigger");

	}

}
