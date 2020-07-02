using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random=System.Random;
using UnityEngine.UI;


public class MultiPlayer : MonoBehaviour {
	bool collided;
	public Text Player1Txt;
	public Text Player2Txt;
	public Text WinTxt;
	int player1;
	int player2;
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
		array = ShuffleArray(array);
		while (array[counter] == 1) {
			Debug.Log ("Shuffled");
			array = ShuffleArray (array);
		}
		player1 = 0;
		player2 = 0;
	}

	// Update is called once per frame
	void FixedUpdate () {
		collided = false;
		transform.Rotate(0, 2f, 0);
		this.transform.position = waypoints [array[counter]].transform.position;

		if (player1 == 5) {
			Time.timeScale = 0;
			WinTxt.text = "Congratulation Player 1, You Won!";
			showPaused ();
		}

		if (player2 == 5) {
			Time.timeScale = 0;
			WinTxt.text = "Congratulation Player 2, You Won!";
			showPaused ();
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
		if(collided){return;}
		collided = true;

		counter++;

		if(other.gameObject.CompareTag("Player1")){
			player1++;
			Play1Txt ();
		}

		else if(other.gameObject.CompareTag("Player2")){
			player2++;
			Play2Txt ();
		}
			

		if (counter > 4 ) {
			array = ShuffleArray(array);
			counter = 0;
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

	void Play1Txt(){
		Player1Txt.text = "Point: " + player1 + "/5";
	}

	void Play2Txt(){
		Player2Txt.text = "Point: " + player2 + "/5";
	}
		
}


