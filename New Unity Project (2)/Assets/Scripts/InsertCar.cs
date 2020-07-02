using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class InsertCar : MonoBehaviour {

	public GameObject Spawn;
	public GameObject Spawn2;
	public Transform Girlcar;
	public Transform Kuro;
	public Transform Josh;
	public Transform Norbus;
	public Transform Feriri;
	public Transform Girlcar2;
	public Transform Kuro2;
	public Transform Josh2;
	public Transform Norbus2;
	public Transform Feriri2;
	public Transform GirlcarSP;
	public Transform KuroSP;
	public Transform JoshSP;
	public Transform NorbusSP;
	public Transform FeririSP;


	void Start () {

		if (GameManagerScript.SinglePlayer) {
			if (GameManagerScript.car == 0) {
				var go = Instantiate (GirlcarSP, Spawn.transform.position, Spawn.transform.rotation);
			} else if (GameManagerScript.car == 1) {
				var go = Instantiate (KuroSP, Spawn.transform.position, Spawn.transform.rotation);
			} else if (GameManagerScript.car == 2) {
				var go = Instantiate (JoshSP, Spawn.transform.position, Spawn.transform.rotation);
			} else if (GameManagerScript.car == 3) {
				var go = Instantiate (NorbusSP, Spawn.transform.position, Spawn.transform.rotation);
			} else if (GameManagerScript.car == 4) {
				var go = Instantiate (FeririSP, Spawn.transform.position, Spawn.transform.rotation);
			}
		}

		else{

		if (GameManagerScript.ReadyPlayerOne) {
			if (GameManagerScript.car == 0) {
				var go = Instantiate (Girlcar, Spawn.transform.position, Spawn.transform.rotation);
			} else if (GameManagerScript.car == 1) {
				var go = Instantiate (Kuro, Spawn.transform.position, Spawn.transform.rotation);
			} else if (GameManagerScript.car == 2) {
				var go = Instantiate (Josh, Spawn.transform.position, Spawn.transform.rotation);
			} else if (GameManagerScript.car == 3) {
				var go = Instantiate (Norbus, Spawn.transform.position, Spawn.transform.rotation);
			} else if (GameManagerScript.car == 4) {
				var go = Instantiate (Feriri, Spawn.transform.position, Spawn.transform.rotation);
			}
		}

		if (GameManagerScript.ReadyPlayerTwo) {
			if (GameManagerScript.car2 == 0) {
					var go2 = Instantiate (Girlcar2, Spawn2.transform.position, Spawn2.transform.rotation);
			} else if (GameManagerScript.car2 == 1) {
					var go2 = Instantiate (Kuro2, Spawn2.transform.position, Spawn2.transform.rotation);
			} else if (GameManagerScript.car2 == 2) {
					var go2 = Instantiate (Josh2, Spawn2.transform.position, Spawn2.transform.rotation);
			} else if (GameManagerScript.car2 == 3) {
					var go2 = Instantiate (Norbus2, Spawn2.transform.position, Spawn2.transform.rotation);
			} else if (GameManagerScript.car2 == 4) {
					var go2 = Instantiate (Feriri2, Spawn2.transform.position, Spawn2.transform.rotation);
			}
		}
				
		}
		GameManagerScript.ReadyPlayerOne = false;
		GameManagerScript.ReadyPlayerTwo = false;
		GameManagerScript.SinglePlayer = false;
		Debug.Log ("Nullázva");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
