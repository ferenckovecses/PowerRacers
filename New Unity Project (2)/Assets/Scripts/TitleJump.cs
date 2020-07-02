using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TitleJump : MonoBehaviour {

	public TextMeshProUGUI text;
	public float frequency = .8f;


	// Use this for initialization
	void Start () {
		text = GetComponent<TextMeshProUGUI>();
		StartCoroutine(BlinkText());
	}

	public IEnumerator BlinkText(){
		while (true) {
			text.text = "Press Enter To Continue!";
			text.text = "";
			yield return new WaitForSeconds (frequency);
			text.text = "Press Enter To Continue!";
			yield return new WaitForSeconds (frequency);
		}
	}
}
