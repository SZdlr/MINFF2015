using UnityEngine;
using System.Collections;

public class FireInterval : MonoBehaviour {
	//fire wall variables
	public float delay = 0.0f; //start delay
	public int interval; //fire interval
	private bool activated = false; //fire active

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > delay){ //if delay over
			if (((int)Time.time)%interval == 0 && !activated){ //if time to fire and not active
				//activate fire wall
				activated = true;
				//activate each individual fire
				foreach (Transform child in transform) {
					ParticleSystem p = child.Find("Afterburner").GetComponent<ParticleSystem>();
					if (p.enableEmission){ //if fire active
						//deactivate fire
						p.enableEmission = false;
						//deactivate trigger
						child.GetComponent<CapsuleCollider>().enabled = false;
					} else { //if fire inactive
						//activate fire
						p.enableEmission = true;
						//activate trigger
						child.GetComponent<CapsuleCollider>().enabled = true;
					}
				}
			} else if (((int)Time.time)%interval == 1){ //if time to stop fire
				//deactivate fire wall
				activated = false;
			}
		}
	}
}
