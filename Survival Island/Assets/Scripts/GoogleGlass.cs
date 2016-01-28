using UnityEngine;
using System.Collections;

public class GoogleGlass : MonoBehaviour {
	
	public TextUpdate InfoText; //Begin Variable for TextUpdate Class, Used to Update Onscreen Prompt 
	public bool Glass = false; //Are You in The Explorer Program?

	// Use this for initialization
	void Start () {
		InfoText = GameObject.FindObjectOfType (typeof(TextUpdate)) as TextUpdate; //Find Dat Class
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter(Collision other) //Method with Collision Event Trigger
	{
		Debug.Log(other.gameObject.tag + " Collided With Google Glasses"); //Extremely Useful Debug Info
		if (other.gameObject.tag == "Player")
		{
			Glass = true;
			Destroy(gameObject);
			InfoText.NewStats("You Encountered an old piece of technology known as Google Glass, Perhaps it will help you...");
		}
	}

	//Do You?
	public bool GotGlass () { 
		return Glass;
	}
}
