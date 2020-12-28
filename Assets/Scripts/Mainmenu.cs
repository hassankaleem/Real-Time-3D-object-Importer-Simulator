using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mainmenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void name(int level){
		if (level == 1) {
			Application.LoadLevel (1);
			PlayerPrefs.SetInt ("level", 1);
		}
		if (level == 2) {
			Application.LoadLevel (1);
			PlayerPrefs.SetInt ("level", 2);
		}
		if (level == 3) {
			Application.LoadLevel (1);
			PlayerPrefs.SetInt ("level", 3);
		
		}
	}
}
