using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {
	
	int log = 0; //No Cheats

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	/**
	 * DEPRECATED
	 * */
	public int LogGain(int Gain) {
		log = log + Gain;
		return log;
	}


	//Gain a certain amount of a certain amount, Sounds Easy
	public string ObjGain(string ObjType, int Gain) {
		if (ObjType == "Debug Cube") {
			return "∞";
		} else if (ObjType == "Log") {
			log = log + Gain;
			return log.ToString();
		}
		return "";
	}

	//Prove that you have gained
	public int Amounts(string ObjType) {
		if (ObjType == "Log") {
			return log;
		}
		return 0;
	}
}
