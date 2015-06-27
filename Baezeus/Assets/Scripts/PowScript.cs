using UnityEngine;
using System.Collections;

public class PowScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("Die", 1f);
	}
	
	void Die() {
		print ("hii");
	//	Destroy (this.gameObject);
		print ("hello");
	}
}
