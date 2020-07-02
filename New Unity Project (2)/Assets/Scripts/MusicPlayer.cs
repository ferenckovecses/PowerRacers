using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class MusicPlayer : MonoBehaviour {

	public AudioClip Music1;
	public AudioClip Music2;

	// Use this for initialization
	IEnumerator Start()
	{
		AudioSource audio = GetComponent<AudioSource>();
		while (true) {
			
			audio.Play ();
			yield return new WaitForSeconds (audio.clip.length);
			audio.clip = Music2;
			audio.Play ();
			yield return new WaitForSeconds (audio.clip.length);
			audio.clip = Music1;
		}
	}
}
