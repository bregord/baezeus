using UnityEngine;
using System.Collections;

public class KindleWalls : MonoBehaviour {
	
		// Use this for initialization
		void OnTriggerEnter (Collider other) 
		{
			if (other.tag == "Critter") {
				Destroy (other.gameObject);
				Destroy (this.gameObject);
			}
		}
	}
