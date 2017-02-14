using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {
	public bool move = false;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (move) { //if moving
			//move downward
			transform.Translate (Vector3.up * -Time.deltaTime * 2, Space.World);

			if (transform.position.y < -5){ //if at end position
				//stop moving
				move = false;
			}
		}
	}

	/* Open door */
	void open (){
		//start moving
		move = true;
	}
}
