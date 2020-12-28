using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickitup : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 currentmouse = Input.mousePosition;
		Ray ray = Camera.main.ScreenPointToRay (currentmouse);


	}



	public Texture2D cursortexture;
	public Vector2 cursorposition;

	void OnMouseEnter(){
		cursorposition = new Vector2 (cursortexture.width / 2, cursortexture.height / 2);
		Cursor.SetCursor (cursortexture,cursorposition , CursorMode.ForceSoftware);

	}
	void OnMouseExit()
	{
		Cursor.SetCursor (null , Vector2.zero, CursorMode.Auto);

	}
	void OnTriggerEnter(Collider obj){
		if (obj.gameObject.tag == "Player") {
			Debug.Log ("pick is there ");
		}
	
	}


}
