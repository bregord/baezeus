using UnityEngine;
using System.Collections;

public class WallEnd : MonoBehaviour {

	void OnTriggerEnter (Collider other) 
	{
		if (other.tag == "Critter") {
			//end game script go!

		}
	}
}
