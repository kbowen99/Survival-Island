using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GlassUpdater : MonoBehaviour {

	//script used to Update "Google Glass" (Right Top Textbox)
	//Seperated from GoogleGlass (used as Collision)
	
	Text DoMagicalConfusingThings;
	GameObject Playr;
	GoogleGlass GlassObj;

	public string UpdateText = "Error 404: Google Glass Not Found"; // Default Message, to encourage the player to search for glasses


	// Use this for initialization
	public void Start () {
		//instantiation
		DoMagicalConfusingThings = GetComponent<Text>();
		Playr = GameObject.Find ("FPSController");
		GlassObj = GameObject.FindObjectOfType (typeof(GoogleGlass)) as GoogleGlass;
		Debug.Log("Google Glass Started"); //Sometimes Start() isnt called....
	}
	
	// Update is called once per frame
	void Update () {
		//if player is wearing GoogleGlass, update Coordinates in topleft (Nice for sense of direction) 
		if (GlassObj.GotGlass() == true) {
			UpdateText = "X: " + (int)(Playr.transform.position.x) + " Y: " + (int)(Playr.transform.position.y) + " Z: " + (int)(Playr.transform.position.z); 
		}
		DoMagicalConfusingThings.text = UpdateText; //unity is a little funky sometimes, Does NOT like being set directly
	}
}
