using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour {

	public GameObject cube;
	private AudioSource source;

	// Use this for initialization
	void Awake () {
		source = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
//		if (Input.GetButtonDown ("Fire1")) {
//			
//		}

//		source.PlayOneShot(source.clip,1F);
		
	}
	// Check for collission. 
	void OnTriggerEnter(Collider col)
	{
		source.PlayOneShot(source.clip,1F);

	}

	void OnTriggerExit(Collider col)
	{

		source.Stop ();
	}


}
