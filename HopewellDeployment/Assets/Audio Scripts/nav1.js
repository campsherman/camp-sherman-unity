#pragma strict

var Nav1Clip:AudioClip;

function OnTriggerExit(o:Collider) {
	Debug.Log("The trigger fired");

	audio.PlayOneShot(Nav1Clip);
}