using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManagerScript : MonoBehaviour {
	[HideInInspector] public static int car = 0;
	[HideInInspector] public static int car2 = 0;
	public AudioSource audioSource;
	static bool AudioBegin = false; 
	static bool GameStarted = false;
	[HideInInspector] public static bool SinglePlayer = false;
	[HideInInspector] public static bool ReadyPlayerOne = false;
	[HideInInspector] public static bool ReadyPlayerTwo = false;
	void Awake()
	{
		audioSource = GetComponent<AudioSource>();

		if (!AudioBegin) {
			audioSource.Play ();
			DontDestroyOnLoad (gameObject);
			AudioBegin = true;
		} 
	}
	void Update () {


		if( SceneManager.GetActiveScene().name == "SoloPlay")
		{
			audioSource.Stop();
			AudioBegin = false;
			GameStarted = true;

		}
		else if(SceneManager.GetActiveScene().name == "VSmode")
		{
			audioSource.Stop();
			AudioBegin = false;
			GameStarted = true;
		}

		else if(SceneManager.GetActiveScene().name == "mainmenu 1")
		{
			if(GameStarted){
				audioSource.Play ();
				GameStarted = false;
			}
		}

		else if(SceneManager.GetActiveScene().name == "SoloSelect")
		{
			if (CharacterSelect.choose) {
				car = CharacterSelect.index;
				Debug.Log (car + ". car");
				SinglePlayer = true;
				CharacterSelect.index = 0;
				CharacterSelect.choose = false;
				SceneManager.LoadScene ("SoloPlay");
			}
				
		}

		else if(SceneManager.GetActiveScene().name == "VsSelect")
		{
			if (CharacterSelect.choose) {
				ReadyPlayerOne = true;
				car = CharacterSelect.index;
			}

			if (TwoCharacterSelect.choose) {
				ReadyPlayerTwo = true;
				car2 = TwoCharacterSelect.index2;
			}

			if (ReadyPlayerOne && ReadyPlayerTwo) {
				CharacterSelect.index = 0;
				TwoCharacterSelect.index2 = 0;
				CharacterSelect.choose = false;
				TwoCharacterSelect.choose = false;
				SceneManager.LoadScene ("VSmode");
			}

		}
	}
}
