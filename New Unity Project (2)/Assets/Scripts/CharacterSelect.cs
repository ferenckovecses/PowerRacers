using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelect : MonoBehaviour {

	public GameObject Girlcar;
	public GameObject Kuro;
	public GameObject Josh;
	public GameObject Norbus;
	public GameObject Feriri;
	List<GameObject> Cars = new List<GameObject>();
	public static int index = 0;
	public static bool choose = false;

	float varakozasmertek = 0.5f;
	float varakozas;


	// Use this for initialization
	void Start () {
		choose = false;
		Cars.Add (Girlcar);
		Cars.Add (Kuro);
		Cars.Add (Josh);
		Cars.Add (Norbus);
		Cars.Add (Feriri);
		varakozas = varakozasmertek;
		Cars [index].GetComponent<Renderer> ().enabled = true;
	}
	
	// Update is called once per frame
	void Update () {

		if (!choose) {
			transform.Rotate (0, 2f, 0);

			if (varakozas < varakozasmertek) {
				varakozas = varakozas + (1f * Time.deltaTime);
			}

			if (Input.GetKey ("left") && varakozas >= varakozasmertek && index > 0) {
				PreviousPlayer1 ();
			}

			if (Input.GetKey ("right") && varakozas >= varakozasmertek && index < 4) {
				NextPlayer1 ();
			}

			if(Input.GetKey("return")){
				ChoosePlayer1 ();
				}
		}
	}

	public void NextPlayer1(){
		if(index<4){
			Cars [index].GetComponent<Renderer> ().enabled = false;
			index++;
			varakozas = 0f;
			Cars [index].GetComponent<Renderer> ().enabled = true;
		}
	}

	public void PreviousPlayer1(){
		if (index > 0) {
			Cars [index].GetComponent<Renderer> ().enabled = false;
			index--;
			varakozas = 0f;
			Cars [index].GetComponent<Renderer> ().enabled = true;
		}
	}

	public void ChoosePlayer1(){
		choose = true;
	}
}
