using UnityEngine;
using System.Collections;

public class Win : MonoBehaviour {

	//Check for a lucky Winner or a death...

	TextUpdate Txt;

	// Use this for initialization
	void Start () {
		Txt = GameObject.FindObjectOfType(typeof (TextUpdate)) as TextUpdate;
	}
	
	// Update is called once per frame
	void Update () {
		//win check
		if (GameObject.Find ("FPSController").transform.position.x < -10) {
			Application.LoadLevel(2);
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
		}
		//death check
		if (GameObject.Find ("FPSController").transform.position.y < 100) {
			GameObject.Find ("FPSController").transform.position = new Vector3(363, 146, 122);
			Txt.NewStats("You Cannot Swim, It seems you need a raft Press 'R' For More Info");
		}
	}
}
