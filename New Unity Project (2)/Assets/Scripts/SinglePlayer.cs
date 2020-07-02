using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random=System.Random;
using UnityEngine.UI;


public class SinglePlayer : MonoBehaviour {
	public Text RoundTxt;
	public Text ChkTxt;
	public GameObject Waypoint1;
	public GameObject Waypoint2;
	public GameObject Waypoint3;
	public GameObject Waypoint4;
	public GameObject Waypoint5;
	GameObject[] pauseObjects;
	int counter;
	int round;
	List<GameObject> waypoints = new List<GameObject>();
	int[] array = {0,1,2,3,4};


	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
		pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnWin");
		hidePaused();
		waypoints.Add(Waypoint1);
		waypoints.Add(Waypoint2);
		waypoints.Add(Waypoint3);
		waypoints.Add(Waypoint4);
		waypoints.Add(Waypoint5);
		counter = 0;
		round = 0;
		array = ShuffleArray(array);
		while (array[counter] == 0) {
			Debug.Log ("Shuffled");
			array = ShuffleArray (array);
		}
		changeText ();
		Checkpoint ();
		Debug.Log (waypoints [array[counter]] + ". pont a kovetkezo!");
	}

	// Update is called once per frame
	void FixedUpdate () {

		transform.Rotate(0, 2f, 0);
		this.transform.position = waypoints [array[counter]].transform.position;


		if (round == 2) {
			Time.timeScale = 0;
			showPaused();
		}
			

		
	}

	//shows objects with ShowOnPause tag
	public void showPaused(){
		foreach(GameObject g in pauseObjects){
			g.SetActive(true);
		}
	}

	//hides objects with ShowOnPause tag
	public void hidePaused(){
		foreach(GameObject g in pauseObjects){
			g.SetActive(false);
		}
	}
		
	void OnTriggerEnter(Collider other){
		counter++;

		if (counter<=4){
			Checkpoint ();
			Debug.Log (waypoints [array[counter]]+ ". pont a kovetkezo!");
		}
			

		if (counter > 4 ) {
			array = ShuffleArray(array);
			counter = 0;
			round++;
			changeText ();
			Checkpoint ();
			Debug.Log (waypoints [array[counter]] + ". pont a kovetkezo!");
		}

	}


	int[] ShuffleArray(int[] array)
	{
		Random r = new System.Random();
		for (int i = array.Length; i > 0; i--)
		{
			int j = r.Next(i);
			int k = array[j];
			array[j] = array[i - 1];
			array[i - 1]  = k;
		}
		return array;
	}

	void changeText(){
		RoundTxt.text = "Round: " + (round+1) + "/2";
	}

	void Checkpoint(){
		ChkTxt.text = "Next point: " + (array[counter]+1);
	}
}


