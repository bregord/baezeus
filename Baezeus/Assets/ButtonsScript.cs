using UnityEngine;
using System.Collections;

public class ButtonsScript : MonoBehaviour {
		
		public void NewGame() {
			Application.LoadLevel("mainGameScreen");
		}
		
		public void Tutorial() {
			Application.LoadLevel ("tutorialScreen");
		}
		
		public void MainMenu() {
			Application.LoadLevel ("startMenuScreen");
		}

}
