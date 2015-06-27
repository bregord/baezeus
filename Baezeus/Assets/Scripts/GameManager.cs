using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public GameObject critter;
	public Vector3 spawnValues;
	private int timePassed = 0;
	public int amountToSpawn;
	// Use this for initialization
	void Start () {
		SpawnWaves ();
	}

	void SpawnWaves(){
		Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
		Quaternion spawnRotation = Quaternion.identity;
		Instantiate (critter, spawnPosition, spawnRotation);
	}

	// Update is called once per frame
	void Update () {
		timePassed++;
		if (timePassed % 100 == 0) {
			for (int i = 0; i< amountToSpawn; i++) {
				SpawnWaves ();
			}
		}
	}
}
