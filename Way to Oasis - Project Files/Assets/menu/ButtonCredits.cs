using UnityEngine;
using System.Collections;

public class ButtonCredits : MonoBehaviour {
	private bool credits = false; //show credits?
	private GameObject credit; //credit image
	private GameObject instruct; //instruction image

	// Use this for initialization
	void Start () {
		credit = this.transform.parent.Find ("Credit").gameObject;
		instruct = this.transform.parent.Find ("Instructions").gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if (credits) { //if credits are active
			//move image upward
			credit.transform.Translate (0, Time.deltaTime * 75,0, Space.World);
			
			if (credit.transform.position.y > 2500){ //if at end position
				//deactivate credits
				click();
			}
		}
	}

	/* On click on button */
	public void click (){
		if (credits) { //if credits are active
			//set to start position
			credit.transform.position.Set(280,-1100,0);
			//deactivate credits
			credit.SetActive(false);
			credits = false;
			//activate instructions
			instruct.SetActive(true);
		} else { //if credits are inactive
			//activate credits
			credit.SetActive(true);
			credits = true;
			//deactivate instructions
			instruct.SetActive(false);
		}
	}
}
