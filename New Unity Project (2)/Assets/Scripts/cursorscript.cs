using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cursorscript : MonoBehaviour {

    public float varakozasmertek = 0.5f;
    [HideInInspector]
    public int hely = 0;
    [HideInInspector]
    public float varakozas;
    public Vector2 jumpoffset;
    public float jumpwait = 0.5f;
    [HideInInspector]
    public bool inair=false;
    [HideInInspector]
    public float jmptpsd;

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2 (0, 0);
        varakozas = varakozasmertek;
        jmptpsd = jumpwait;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        //jumping effect timer
        jmptpsd += 1f * Time.deltaTime;

        //jump up
        if(inair == false && jmptpsd >= jumpwait)
        {
            gameObject.GetComponent<RectTransform>().anchoredPosition += jumpoffset;
            inair = true;
            jmptpsd = 0f;
        }

        //fall down
        if(inair == true && jmptpsd >= jumpwait)
        {
            gameObject.GetComponent<RectTransform>().anchoredPosition -= jumpoffset;
            inair = false;
            jmptpsd = 0f;
        }

        //time passed
        if (varakozas < varakozasmertek)
        {
            varakozas = varakozas + (1f * Time.deltaTime);
        }

        //downward movement
        if (Input.GetKey("s") && hely==0 && varakozas >= varakozasmertek)
        {
            gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2 (0,-45);
            hely = 1;
            varakozas = 0f;
            jmptpsd = 0f;
            inair = false;
        }

        if (Input.GetKey("s") && hely == 1 && varakozas >= varakozasmertek)
        {
            gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -90);
            hely = 2;
            varakozas = 0f;
            jmptpsd = 0f;
            inair = false;
        }

        if (Input.GetKey("s") && hely == 2 && varakozas >= varakozasmertek)
        {
            gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -135);
            hely = 3;
            varakozas = 0f;
            jmptpsd = 0f;
            inair = false;
        }

        if (Input.GetKey("s") && hely == 3 && varakozas >= varakozasmertek)
        {
            gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -180);
            hely = 4;
            varakozas = 0f;
            jmptpsd = 0f;
            inair = false;
        }

        //upward movement
        if (Input.GetKey("w") && hely == 4 && varakozas >= varakozasmertek)
        {
            gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -135);
            hely = 3;
            varakozas = 0f;
            jmptpsd = 0f;
            inair = false;
        }

        if (Input.GetKey("w") && hely == 3 && varakozas >= varakozasmertek)
        {
            gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -90);
            hely = 2;
            varakozas = 0f;
            jmptpsd = 0f;
            inair = false;
        }

        if (Input.GetKey("w") && hely == 2 && varakozas >= varakozasmertek)
        {
            gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -45);
            hely = 1;
            varakozas = 0f;
            jmptpsd = 0f;
            inair = false;
        }

        if (Input.GetKey("w") && hely == 1 && varakozas >= varakozasmertek)
        {
            gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
            hely = 0;
            varakozas = 0f;
            jmptpsd = 0f;
            inair = false;
        }

        //scene loading
        if(Input.GetKey("return") && hely == 0)
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
            Application.Quit();
        }
    }
}
