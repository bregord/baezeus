using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {


	Plane _groundPlane;
	public Vector3 groundOrigin = Vector3.zero;
	public Vector3 groundNormal = Vector3.up;

	// Use this for initialization
	void Start () {
		_groundPlane = new Plane(groundNormal, groundOrigin);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate(){

	}
}
