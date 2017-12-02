#pragma strict

var thingon : GameObject;
var duration : float = 0;

function Start () {
    yield WaitForSeconds(duration);
    thingon.SetActive(true); 
}