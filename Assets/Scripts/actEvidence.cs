using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class actEvidence : MonoBehaviour
{
	public bool collide = false;
	public bool isPressed = false;
	public GameObject evidenceObject;
	
	private void Start(){
		evidenceObject.active = false;
	}
	
    private void Update(){
		if(Input.GetKeyDown(KeyCode.E)){
			if(collide == true){
				isPressed = true;
				showEvidence();
			}
		}
		if(collide == false || Input.GetKeyUp(KeyCode.E)){
			isPressed = false;
			hideEvidence();
		}
	}
	
	void showEvidence(){
			evidenceObject.active = true;
	}
	void hideEvidence(){
			evidenceObject.active = false;
	}
	
	void OnTriggerEnter2D(Collider2D other){
		collide = true;
		if(Input.GetKeyDown(KeyCode.E)){
			isPressed = true;
		}
		if(Input.GetKeyUp(KeyCode.E)){
			isPressed = false;
			evidenceObject.active = false;
		}
	}
	
	void OnTriggerExit2D(Collider2D other){
		//Debug.Log("Trigger Exit");
		collide = false;
		//Debug.Log(collide);
		isPressed = false;
		evidenceObject.active = false;
	}
	
}
