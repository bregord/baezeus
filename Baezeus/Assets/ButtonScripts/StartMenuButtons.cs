using UnityEngine;
using System.Collections;

public class StartMenuButtons : MonoBehaviour {

	public void NewGame() {
		Application.LoadLevel("mainGameScreen");
	}

	public void ContinueGame() {
		Application.LoadLevel ("mainGameScreen");
	}

	public void Store() {
		Application.LoadLevel ("mainGameScreen");
	}

	public void Tutorial() {
		Application.LoadLevel ("mainGameScreen");
	}

	public void Settings() {
		Application.LoadLevel ("mainGameScreen");
	}
}
