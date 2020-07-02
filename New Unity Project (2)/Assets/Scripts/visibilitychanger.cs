using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class visibilitychanger : MonoBehaviour {

    public GameObject elsokep;
    public GameObject masodikkep;
    public GameObject harmadikkep;
    public GameObject negyedikkep;
    public GameObject otodikkep;
    //public GameObject masodikkep;
    public float varakozasmertek = 0.5f;
    [HideInInspector]
    public int hely = 0;
    [HideInInspector]
    public float varakozas;

    // Use this for initialization
    void Start () {
        elsokep.SetActive(true);
        masodikkep.SetActive(false);
        harmadikkep.SetActive(false);
        negyedikkep.SetActive(false);
        otodikkep.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        //time passed
        if (varakozas < varakozasmertek)
        {
            varakozas = varakozas + (1f * Time.deltaTime);
        }

        //downward movement
		if ((Input.GetKey("s") || Input.GetKey("down")) && hely == 0 && varakozas >= varakozasmertek)
        {
            elsokep.SetActive(false);
            masodikkep.SetActive(true);
            hely = 1;
            varakozas = 0f;
        }

		if ((Input.GetKey("s") || Input.GetKey("down")) && hely == 1 && varakozas >= varakozasmertek)
        {
            masodikkep.SetActive(false);
            harmadikkep.SetActive(true);
            hely = 2;
            varakozas = 0f;
        }

		if ((Input.GetKey("s") || Input.GetKey("down")) && hely == 2 && varakozas >= varakozasmertek)
        {
            harmadikkep.SetActive(false);
            negyedikkep.SetActive(true);
            hely = 3;
            varakozas = 0f;
        }

		if ((Input.GetKey("s") || Input.GetKey("down")) && hely == 3 && varakozas >= varakozasmertek)
        {
            negyedikkep.SetActive(false);
            otodikkep.SetActive(true);
            hely = 4;
            varakozas = 0f;
        }

        //upward movement
		if ((Input.GetKey("w") || Input.GetKey("up")) && hely == 4 && varakozas >= varakozasmertek)
        {
            otodikkep.SetActive(false);
            negyedikkep.SetActive(true);
            hely = 3;
            varakozas = 0f;
        }

		if ((Input.GetKey("w") || Input.GetKey("up")) && hely == 3 && varakozas >= varakozasmertek)
        {
            negyedikkep.SetActive(false);
            harmadikkep.SetActive(true);
            hely = 2;
            varakozas = 0f;
        }

		if ((Input.GetKey("w") || Input.GetKey("up")) && hely == 2 && varakozas >= varakozasmertek)
        {
            harmadikkep.SetActive(false);
            masodikkep.SetActive(true);
            hely = 1;
            varakozas = 0f;
        }

		if ((Input.GetKey("w") || Input.GetKey("up")) && hely == 1 && varakozas >= varakozasmertek)
        {
            masodikkep.SetActive(false);
            elsokep.SetActive(true);
            hely = 0;
            varakozas = 0f;
        }

        //scene loading
        if (Input.GetKey("return") && hely == 0)
        {
            SceneManager.LoadScene("SoloSelect");
        }

        if (Input.GetKey("return") && hely == 1)
        {
            SceneManager.LoadScene("VsSelect");
        }

        if (Input.GetKey("return") && hely == 2)
        {
			SceneManager.LoadScene("Credits");
        }

        if (Input.GetKey("return") && hely == 3)
        {
            Debug.Log("no3");
        }

        if (Input.GetKey("return") && hely == 4)
        {
            Debug.Log("game quit");
            Application.Quit();
        }
    }
}
