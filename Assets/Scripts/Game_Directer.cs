using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Directer : MonoBehaviour {


	public Canvas canvasitemget = null;

	// Use this for initialization
	void Start () {
		itemwinreverse ();
	}
	
	// Update is called once per frame
	void Update () {
		if (item.item_fish_number == 1) {
			itemwinreverse ();
			item.item_fish_number += 1;
		} 
		else if (Input.GetKey (KeyCode.DownArrow) && item.item_fish_number == 2) {
			itemwinreverse ();
			item.item_fish_number += 1;
		}
	}

	public void itemwinreverse(){
		if (canvasitemget != null) {
			canvasitemget.enabled = !canvasitemget.enabled;
		}
	}

}
