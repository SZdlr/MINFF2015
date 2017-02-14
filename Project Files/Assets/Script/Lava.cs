using UnityEngine;
using System.Collections;

public class Lava : MonoBehaviour {
	private GameObject player; //player object
	private bool dead = false; //player status

	//fade to/from black
	private bool reverse = false; //true: fade from black
	private float alphaFadeValue = 0; //transparency
	public int fadeTime = 1; //fade duration
	public Texture blackTexture; //black

	// Use this for initialization
	void Start () {
		//set player object
		player = GameObject.FindWithTag ("Player"); 
	}
	
	// Update is called once per frame
	void Update () {

	}

	/* On trigger: Set player status to dead */
	void OnTriggerEnter() {
		dead = true;
	}

	/* Respawn player at last runestone */
	void OnGUI ()	{
		if (dead) { //if player died
			//fade to black
			alphaFadeValue = Mathf.Clamp01 (alphaFadeValue + (Time.deltaTime / fadeTime));
			GUI.color = new Color (0, 0, 0, alphaFadeValue);
			GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), blackTexture);

			if (alphaFadeValue == 1) { //if fade completed
				//set player to runestone position
				player.transform.position = GameObject.FindWithTag ("Respawn").gameObject.transform.Find ("pos").transform.position;
				//set player status to alive
				dead = false;
				//start fade from black
				reverse = true;
			}
		} else if (reverse) { //
			//fade from black
			alphaFadeValue = Mathf.Clamp01 (alphaFadeValue - (Time.deltaTime / fadeTime));
			GUI.color = new Color (0, 0, 0, alphaFadeValue);
			GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), blackTexture);
			
			if (alphaFadeValue == 0) { //if fade completed
				//stop fading
				reverse = false;
			}
		}
	}
}
