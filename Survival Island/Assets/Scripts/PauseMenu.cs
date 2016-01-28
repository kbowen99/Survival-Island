using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class PauseMenu : MonoBehaviour {

	EventSystem EventSys; //Basic declaration

	// Use this for initialization
	void Start () {
		EventSys = gameObject.GetComponent<EventSystem> (); //initialize eventsystem
	}
	
	// Update is called once per frame
	void Update () {

		//NULL prevention
		try {
			//pull info from the event system, Act based on last selected gameobject
			if (EventSys.currentSelectedGameObject.ToString() == "Resume (UnityEngine.GameObject)") {
				Debug.Log("Loading Level 1 (Game)");
				Application.LoadLevel(1);
			} else if (EventSys.currentSelectedGameObject.ToString() == "MainMenu (UnityEngine.GameObject)") {
				Debug.Log("Loading Level 0 (Main Menu)");
				Application.LoadLevel(0);
			} else if (EventSys.currentSelectedGameObject.ToString() == "Quit (UnityEngine.GameObject)") {
				Debug.Log("See You Later Quitter"); 
				Application.Quit();
			}
		} catch {}
	}
}
