using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
This script allows the player to press the "e" key
when they overlap an interactable evidence object.
When e is pressed another set of objects will appear,
one of which is the evidence to collect and will be clickable.
THIS IS NOT FINISHED AS OF Nov-19
*/
public class actEvidence : MonoBehaviour
{
	//variable for hitbox collide, interact buttone is pressed,
	//and for other "evidence" object
	public bool collide = false;
	public bool isPressed = false;
	public bool toggle = false;
	public GameObject evidenceObject;
	
	//disable evidence object from play space
	private void Start(){
		evidenceObject.active = false;
	}
	
    private void Update(){
		//check if "e" is pressed
		if(Input.GetKeyDown(KeyCode.E)){
			if(collide == true){
				isPressed = true;
				if(toggle == true){
					toggle = false;
				}
				else{
					toggle = true;
				}
			}
		}
		else if(collide == false){
			isPressed = false;
			toggle = false;
			//hideEvidence();
		}
		if(toggle == true){
			showEvidence();
		}
		else{
			hideEvidence();
		}
	}
	
	//enables evidence object
	void showEvidence(){
			evidenceObject.active = true;
	}
	//disables evidence object
	void hideEvidence(){
			evidenceObject.active = false;
	}
	
	//activates when player hitbox collides with interactable object
	void OnTriggerEnter2D(Collider2D other){
		collide = true;
		if(Input.GetKeyDown(KeyCode.E)){
			isPressed = true;
		}
		if(Input.GetKeyUp(KeyCode.E)){
			isPressed = false;
		}
	}
	
	//activated when hitboxes no longer collide
	void OnTriggerExit2D(Collider2D other){
		collide = false;
		isPressed = false;
		evidenceObject.active = false;
	}
	
}
