#pragma strict

var thing1 : GameObject;
var thing2 : GameObject;
var objectTag : String;

function OnTriggerEnter (other : Collider) {
        if(other.gameObject.tag == objectTag){
            thing1.SetActive(true);
            thing2.SetActive(true);
    }
}