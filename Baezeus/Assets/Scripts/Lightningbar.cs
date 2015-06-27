using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Lightningbar : MonoBehaviour {

	public void fillBar(float dec) {
		Image image = GetComponent<Image> ();
		Image.fillAmount = dec;
	}
}
