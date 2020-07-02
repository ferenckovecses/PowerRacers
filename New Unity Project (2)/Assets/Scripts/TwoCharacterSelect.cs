using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoCharacterSelect : MonoBehaviour {

	public GameObject Girlcar;
	public GameObject Kuro;
	public GameObject Josh;
	public GameObject Norbus;
	public GameObject Feriri;
	List<GameObject> Cars = new List<GameObject>();
	public static int index2 = 0;
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
		Cars [index2].GetComponent<Renderer> ().enabled = true;
	}
	
	// Update is called once per frame
	void Update () {

		if (!choose) {
			transform.Rotate (0, -2f, 0);

			if (varakozas < varakozasmertek) {
				varakozas = varakozas + (1f * Time.deltaTime);
			}

			if (Input.GetKey ("a") && varakozas >= varakozasmertek && index2 > 0) {
				PreviousPlayer2 ();
			}

			if (Input.GetKey ("d") && varakozas >= varakozasmertek && index2 < 4) {
				NextPlayer2 ();
			}

			if (Input.GetKey ("space")) {
				ChoosePlayer2 ();
			}
		} 

	}

	public void NextPlayer2(){
		if (index2 < 4) {
			Cars [index2].GetComponent<Renderer> ().enabled = false;
			index2++;
			varakozas = 0f;
			Cars [index2].GetComponent<Renderer> ().enabled = true;
		}
	}

	public void PreviousPlayer2(){
	
		if (index2 > 0) {
			Cars [index2].GetComponent<Renderer> ().enabled = false;
			index2--;
			varakozas = 0f;
			Cars [index2].GetComponent<Renderer> ().enabled = true;
		}
	}

	public void ChoosePlayer2(){
		choose = true;
	}

}
