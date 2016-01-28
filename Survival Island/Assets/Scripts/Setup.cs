using UnityEngine;
using System.Collections;

public class Setup : MonoBehaviour {

	// Use this for initialization
	void Start () {

        //Disable the Mouse
		Cursor.lockState = CursorLockMode.Locked;
		//& hide it too
		Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
		//did you really think you were trapped?
		if (Input.GetKey ("escape")) {
			Debug.Log("Loading Level 3 (Pause)");
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
			Application.LoadLevel(3);
		}
	}
}
