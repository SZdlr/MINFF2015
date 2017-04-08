using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/* On trigger: Start firework */
	void OnTriggerEnter(){
		this.transform.Find ("Fireworks").gameObject.SetActive (true);
		this.transform.Find ("Fireworks (1)").gameObject.SetActive (true);
		this.transform.Find ("Flare").gameObject.SetActive (true);
		this.transform.Find ("Flare (1)").gameObject.SetActive (true);
	}
}
