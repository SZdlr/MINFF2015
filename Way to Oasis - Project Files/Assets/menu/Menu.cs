using UnityEngine;
using System.Collections;
using UnityStandardAssets.ImageEffects;

public class Menu : MonoBehaviour { 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("escape")) { //if esc key pressed
			//activate menu UI
			GameObject.FindGameObjectWithTag("Menu").GetComponent<Canvas>().enabled = true;
			//activate blurr
			GameObject.FindGameObjectWithTag("MainCamera").GetComponent<BlurOptimized>().enabled = true;;
		}
	}
}
