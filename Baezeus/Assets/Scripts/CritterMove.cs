using UnityEngine;
using System.Collections;

public class CritterMove : MonoBehaviour {
	public float distance;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z + distance);
	}
}
