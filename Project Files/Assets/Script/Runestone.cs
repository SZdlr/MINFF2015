using UnityEngine;
using System.Collections;

public class Runestone : MonoBehaviour {
	public GameObject flare;
	public GameObject spawnPos;
	public bool activated = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	/* On trigger: Activate runestone as respawn point */
	void OnTriggerEnter() {
		if(!activated){ //if not already activated
			//deactivate last runestone
			GameObject.FindWithTag("Respawn").gameObject.tag = "Untagged";
			//activate this runestone
			this.tag = "Respawn";
			activated = true;
			//activate blue light
			flare.SetActive(true);
		}
	}
	
}
