using UnityEngine;
using System.Collections;

public class EndGameWall : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter (Collider other) 
	{
		if (other.tag == "Critter") {

			// End game script here to be triggered cuz BaeZeus is dead
		}
	}
}
