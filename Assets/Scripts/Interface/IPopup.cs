using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//place script on interractable object
public class IPopup : MonoBehaviour {
	
	//Sets up image field for script in inspector
	[SerializeField] private Image customImage;
	
	//turns off image on startup
	private void Start(){
		customImage.enabled = false;
    }
	
	//enables image when collision trigger begins
	void OnTriggerEnter2D(Collider2D other){
		if(other.CompareTag("Player")){
			customImage.enabled = true;
		}
	}
	
	//disables image when collision trigger ends
	void OnTriggerExit2D(Collider2D other){
		if(other.CompareTag("Player")){
			customImage.enabled = false;
		}
	}
}