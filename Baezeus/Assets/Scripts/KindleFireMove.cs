using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class KindleFireMove : MonoBehaviour {

	private bool collided = false;
	public float distance = 0.05f;
	public float accSpeedFact;
	public GameObject explosion;
	private ArrayList myExplosions = new ArrayList();
	private int time = 0;
	// Use this for initialization
	void OnTriggerEnter (Collider other) 
	{
		 if (other.tag == "Critter") {

			GameObject myObj = (GameObject) Instantiate (explosion, other.transform.position, Quaternion.Euler (90,0,0));
			print ("eyyy lamo");
			Destroy (other.gameObject);
			// Destroy (myObj);
			collided = true;
		    Destroy (myObj, 0.5f);
			// Vector3 myexplose = new Vector3(other.transform.position.x, other.transform.position.y, 0f);
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		time++;
		if (collided) {
			distance += accSpeedFact;
			transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z - distance);
		}

	}


}
