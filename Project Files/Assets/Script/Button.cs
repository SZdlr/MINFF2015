using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {
	public int number = 0; //button position
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	/* On trigger: Send message to door */
	void OnTriggerEnter() {
		//wrap parameters
		Parameter par = new Parameter(number, gameObject);
		//send message to door
		transform.parent.BroadcastMessage ("buttonPressed",par);
	}
}

/* Because BroadcastMessage only has 1 parameter */
public class Parameter{
	public int number; //button position
	public GameObject button; //button object
	
	public Parameter(int nmb, GameObject obj){
		number = nmb;
		button = obj;
	}
}
