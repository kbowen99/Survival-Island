using UnityEngine;
using System.Collections;

public class CreditScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	//used to quickly close out of prompts for credits & Pause Menu
	void Update () {
		if (Input.GetKey ("escape")) {
			Debug.Log("Loading Level 0 (Main Menu)");
			Application.LoadLevel(0); // Lvl 0 as defined in build settings
		}
	}
}
