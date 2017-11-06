#pragma strict

var thingon : GameObject;
var thingoff : GameObject;
var objectTag : String;

function OnTriggerEnter (other : Collider) {
        if(other.gameObject.tag == objectTag){
            thingon.SetActive(true);
            thingoff.SetActive(false);
    }
}