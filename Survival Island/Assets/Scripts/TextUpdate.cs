using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class TextUpdate : MonoBehaviour {

	//Give the User (semi) useful Information

	Text DoMagicalConfusingThings;
	public string UpdateText = "Debug Build 0.1";
	int Tmr = 0;

	// Use this for initialization
	public void Start () {
		DoMagicalConfusingThings = GetComponent<Text>();
		Debug.Log("Text Started");
	}
	
	// Update is called once per frame
	void Update () {
		Tmr++; //"Timer" using the .1 sec Update() time

		//show message for ~3.5 sec then hide it
		if (Tmr < 350) {
			DoMagicalConfusingThings.text = UpdateText;
		} else {
			DoMagicalConfusingThings.text = " ";
		}
	}
	
	public void NewStats (string stat) {
		UpdateText = stat;
		Tmr = 0;
	}
}
