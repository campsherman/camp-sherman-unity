using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewController : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;
	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// Late Update is called once per frame but after everything else has already been run. 
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
