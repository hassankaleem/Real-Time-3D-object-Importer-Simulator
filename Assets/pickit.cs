
using UnityEngine;
using System.Collections;

public class pickit : MonoBehaviour {

	private Transform taker;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown("t")) {

			transform.parent = taker;

		} else if(Input.GetKeyDown("g")) {

			transform.parent = null;

		}

	}

	void OnTriggerEnter (Collider col) {

		if(col.CompareTag("Player")) {
			Debug.Log ("collosin enter");
			taker = col.transform;

		}

	}    

	void OnTriggerExit (Collider col) {

		if(col.CompareTag("Player")) {
			taker = null;
		}

	}
}