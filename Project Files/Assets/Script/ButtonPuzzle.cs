using UnityEngine;
using System.Collections;

public class ButtonPuzzle : MonoBehaviour {
	private int current; //current position in puzzle
	
	// Use this for initialization
	void Start () {
		//start position
		current = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	/* Method called from buttons if stepped on */
	void buttonPressed (Parameter button) {
		//button order: 249531678
		
		switch (current) { //is button pressed the right one?
		case 0:
			if (button.number == 2) { //if right number
				//advance position
				current++;
				//move button
				button.button.BroadcastMessage("open");
			}
			break;
		case 1:
			if (button.number == 4) {
				current++;
				button.button.BroadcastMessage("open");
			}
			break;
		case 2:
			if (button.number == 9) {
				current++;
				button.button.BroadcastMessage("open");
			}
			break;
		case 3:
			if (button.number == 5) {
				current++;
				button.button.BroadcastMessage("open");
			}
			break;
		case 4:
			if (button.number == 3) {
				current++;
				button.button.BroadcastMessage("open");
			}
			break;
		case 5:
			if (button.number == 1) {
				current++;
				button.button.BroadcastMessage("open");
			}
			break;
		case 6:
			if (button.number == 6) {
				current++;
				button.button.BroadcastMessage("open");
				Debug.Log(7+"");
			}
			break;
		case 7:
			if (button.number == 7) {
				current++;
				button.button.BroadcastMessage("open");
			}
			break;
		case 8:
			if (button.number == 8) {
				current++;
				button.button.BroadcastMessage("open");
				//open door
				GameObject.FindWithTag ("Door").BroadcastMessage ("open");
			}
			break;
		}
	}
}