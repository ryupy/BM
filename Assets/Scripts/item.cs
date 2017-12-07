using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour {

	public static int item_fish_number;

	// Use this for initialization
	void Start (){
		item_fish_number = 0;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D collision){
		if (collision.tag == "Player") {
			Destroy (gameObject);
			item_fish_number += 1;
		} else {
			item_fish_number += 0;
		}
	}


}
