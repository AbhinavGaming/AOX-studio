
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class collision : MonoBehaviour {

	// Use this for initialization

	public playermovement mov;

	
	// Update is called once per frame
	void OnCollisionEnter (Collision collisionInfo) {

		if (collisionInfo.collider.tag == "obstacle") {
		
			mov.enabled  = false;
			FindObjectOfType<GameManager> ().EndGame();
		
		}
	}
}
