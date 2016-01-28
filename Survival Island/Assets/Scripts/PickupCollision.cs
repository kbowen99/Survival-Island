using UnityEngine;
using System.Collections;

public class PickupCollision : MonoBehaviour {

	public string Object = "Debug Cube"; //Laziness is Key, "Fall back" object
	public bool isPickedUp;

	public TextUpdate InfoText; //Declare Variable for TextUpdate Object, Used to Update Onscreen Prompt 
	public Inventory Inv; //Declare Inventory Object

	// Use this for initialization
	void Start () {
		isPickedUp = false; // You have to actually pick up the item before you may use it

		InfoText = GameObject.FindObjectOfType (typeof(TextUpdate)) as TextUpdate; //The only form of initializing a class that unity 5 likes
		Inv = GameObject.FindObjectOfType (typeof(Inventory)) as Inventory;

		RandomSpawn (); //More Playability! Now The developers are as lost as everyone else!
	}
	
	// Update is called once per frame
	void Update () {} //Not used Here

	void OnCollisionEnter(Collision other) //Method with Collision Event Trigger
	{
		Debug.Log(other.gameObject.tag + " collided with " + Object); //Extremely Useful Debug Info
		if (other.gameObject.tag == "Player" && isPickedUp == false)
		{
			isPickedUp = true;
			Destroy(gameObject); //Kill it! Kill it with Fire!
			Debug.Log("Player sucessfully picked up a " + Object);
			Debug.Log(Inv.LogGain(0) + 1);
			if (Inv.LogGain(0) == 0) {
				InfoText.NewStats("You encountered a log, perhaps it will be of use");
				Inv.LogGain(1);
			} else {
			InfoText.NewStats("You have "  + Inv.LogGain(1) + " " + Object + "s");
			}
		}
	}

	void RandomSpawn() {
		//Really Simple Randomization Code, Defines a spawnable range for X & Z where Logs May Spawn. Logs spawn at constant Y height of 200 using gravity to balance on the ground
		transform.position = new Vector3 ((float)(Random.Range (342, 499)), 200, (float)(Random.Range (3, 499)));
		Debug.Log ("Log Positioned @: " + transform.position.ToString()); //I never said anything about cheating, did I?
	}
}
