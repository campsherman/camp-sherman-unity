using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// For later use. 
/// <summary>
/// Boundary Class require the System.Serializable to be accessible within the project. 
/// Don't need to know how to do this just use it. 
/// </summary>
[System.Serializable]
public class Boundary
{
	public float xMin, xMax, zMin, zMax;
}


public class UserMovement : MonoBehaviour {


	public float speed;

	public Boundary boundary;



	private Rigidbody rb;


	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	/* 	Update is called before rendering a frame. 
	 * 
	 * 
	 * 
	 * 
	 * Game code goes here. 
	*/



	void Update () {


	}
	/* FixedUpdate is called before physics calculations
	 * 
	 * 
	 * 
	 * 
	 * and is where our movement code goes.  
	*/

	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		// Gets the calculation of movement. 
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		// This moves us. 
		rb.velocity = movement * speed;


		// This constrains the movement at the edges of the map.
		// <Rigidbody>.position teleports the player object to defined coordinates. 
		rb.position = new Vector3 
			(
				Mathf.Clamp (rb.position.x, boundary.xMin, boundary.xMax), 
				0.0f, 
				Mathf.Clamp (rb.position.z, boundary.zMin, boundary.zMax)
			);
		

	}
}
