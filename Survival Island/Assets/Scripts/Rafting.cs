using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class Rafting : MonoBehaviour {
	Inventory Inv;
	GameObject Playr;
	TextUpdate Txt;

	int PlayerX;
	int PlayerZ;

	bool riding;
	bool isPlaced = false;

	// Use this for initialization
	void Start () {
		//Super Fun initialization
		Inv = GameObject.FindObjectOfType (typeof(Inventory)) as Inventory;
		Playr = GameObject.Find ("FPSController");
		Txt = GameObject.FindObjectOfType (typeof(TextUpdate)) as TextUpdate;
	}
	
	// Update is called once per frame
	void Update () {
		if (Inv.Amounts ("Log") > 5) { 
			//"Summoning" a raft (near the water of course)
			if (Input.GetKey (KeyCode.R) && Playr.transform.position.y < 105) {
				transform.position = new Vector3 ((float)(Playr.transform.position.x), 102, (float)(Playr.transform.position.z));
				isPlaced = true;
			} else if (Input.GetKeyDown (KeyCode.E) && Playr.transform.position.y < 105 && isPlaced == true) {
				//riding toggle
				riding = !riding;
			} else if (Input.GetKey (KeyCode.R) && Playr.transform.position.y > 104) {
				Txt.NewStats("You are Too far above the water");
			} else if (Input.GetKeyDown (KeyCode.E) && Playr.transform.position.y < 105 && isPlaced == true) {
				Txt.NewStats("Did You Place A Raft?");
			}
			if (riding == true) {
				//Make the raft follow you
				transform.position = transform.position + new Vector3 ((float)(Playr.transform.position.x - transform.position.x), 0, (float)(Playr.transform.position.z - transform.position.z));
			}
		} else if (Input.GetKey (KeyCode.R) || Input.GetKey (KeyCode.E)) {
			Txt.NewStats("You Need " + (6 - Inv.Amounts ("Log")) + " More Logs Before you can make a raft");
		}
	}
}
