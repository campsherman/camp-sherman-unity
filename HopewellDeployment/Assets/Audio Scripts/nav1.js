#pragma strict

var Nav1Clip:AudioClip;

function OnTriggerExit(o:Collider) {
	Debug.Log("The trigger fired");

	GetComponent.<AudioSource>().PlayOneShot(Nav1Clip);
}