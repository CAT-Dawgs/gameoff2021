using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class actEvidence : MonoBehaviour
{
	
	public bool isPressed = false;
	
    private void Update(){
		if(Input.GetKeyDown(KeyCode.E)){
			isPressed = true;
		}
		if(Input.GetKeyUp(KeyCode.E)){
			isPressed = false;
		}
	
	}
	
	void OnTriggerEnter2D(Collider2D other){
		if(Input.GetKeyDown(KeyCode.E)){
			isPressed = true;
		}
		if(Input.GetKeyUp(KeyCode.E)){
			isPressed = false;
		}
	}
	
	void OnTriggerExit2D(Collider2D other){
		isPressed = false;
	}
}
