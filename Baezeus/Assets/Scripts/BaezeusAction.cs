using UnityEngine;
using System.Collections;

public class BaezeusAction : MonoBehaviour {

	public float distance;
	public float lenFloat;
	private float time = 0;
	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter (Collider other) 
	{
		if (other.tag == "Critter") {
			Destroy (other.gameObject);
			// End game script here to be triggered cuz BaeZeus is dead
		}
	}

	// Update is called once per frame
	void FixedUpdate () {
		transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z + distance* Mathf.Sin (time));
		time += lenFloat;
	}
}