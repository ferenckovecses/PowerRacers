using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Tag : MonoBehaviour {

	// Use this for initialization
	void Start () {

		foreach(Transform t in transform)
		{
			t.gameObject.tag = "Player2";
		}
		gameObject.tag = "Player2";

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
