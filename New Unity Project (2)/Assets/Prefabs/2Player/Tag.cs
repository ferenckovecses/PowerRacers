using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tag : MonoBehaviour {

	// Use this for initialization
	void Start () {

		foreach(Transform t in transform)
		{
			t.gameObject.tag = "Player1";
		}
		gameObject.tag = "Player1";

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
