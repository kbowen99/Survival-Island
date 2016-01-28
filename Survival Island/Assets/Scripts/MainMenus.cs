using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class MainMenus : MonoBehaviour {

	//Main Menu system

	EventSystem EventSys; //Grab info from EventSystem

	//Make sure action is called ONCE
	bool HasPlayed = false;
	bool HasHelp = false;
	bool HasInfos = false;

	// Use this for initialization
	void Start () {
		//initializatio of course
		EventSys = gameObject.GetComponent<EventSystem>();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ( " '" + EventSys.currentSelectedGameObject + "' Selected"); //Print Currently Selected Object, Gameobjects are NOT called by name: They are called by '<name> (UnityEngine.GameObject)' 

		//NULL object catch
		try { 
			//Check the Eventsystem for last selected gameobject (Hopefully a button), and act based on that
			if (EventSys.currentSelectedGameObject.ToString() == "Play (UnityEngine.GameObject)" && HasPlayed == false) {
				HasPlayed = true;
				Application.LoadLevel(1);
			} else if (EventSys.currentSelectedGameObject.ToString() == "Help (UnityEngine.GameObject)" && HasHelp == false) {
				Debug.Log("Help Press"); //No Longer Called 'Help'
				HasHelp = true;
				HasInfos = false;
				Application.OpenURL("https://sites.google.com/site/survivalisland3/help");
			} else if (EventSys.currentSelectedGameObject.ToString() == "Controls (UnityEngine.GameObject)" && HasInfos == false) {
				HasInfos = true;
				HasHelp = false;
				Debug.Log("Loading Level 4 (Controls Prompt)");
				Application.LoadLevel(4);
			} else if (EventSys.currentSelectedGameObject.ToString() == "Credits (UnityEngine.GameObject)") {
				Application.LoadLevel(2);
			} else if (EventSys.currentSelectedGameObject.ToString() == "Quit (UnityEngine.GameObject)") {
				Application.Quit();
				Debug.Log ("If You Are Seeing this, Something is broken. My Game should be dead by now"); //Application.Quit() Does not work in editor
			}
		} catch {} //extremely complicated Null Prevention
	}
}
