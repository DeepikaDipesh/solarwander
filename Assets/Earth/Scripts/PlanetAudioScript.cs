using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetAudioScript : MonoBehaviour {

	public AudioClip audio;
	public GameObject trigger;
	// Use this for initialization
	void Start () {
		
		GetComponent<AudioSource> ().playOnAwake = false;
		GetComponent<AudioSource> ().clip = audio;
	}

	void OnCollisionEnter(Collider collision)
	{
		if (collision.tag == "MainCamera") {

			trigger.SetActive (true);
			GetComponent<AudioSource> ().Play ();
		}
	}
}
