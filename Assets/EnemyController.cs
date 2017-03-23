using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {


	public GameObject player;
	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		//transform.position
		//player.transform.position

		Vector3 playerToZombie = player.transform.position - transform.position;


		if (Vector3.Distance (transform.position, player.transform.position) < 30f) {

			//transform.LookAt (player.transform);

			transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.LookRotation (playerToZombie),0.1f);



			if (Vector3.Distance (transform.position, player.transform.position) < 5f) {

				//enemy will attack
				anim.SetBool ("isWalking", false);
				anim.SetBool ("isAttacking", true);


			} else {

				//ennemy will walk

				anim.SetBool ("isWalking", true);
				anim.SetBool ("isAttacking", false);
			}






		}





	}
}
