using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door_loadscene : MonoBehaviour {

	bool near_loadscene = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow) && near_loadscene){
			SaveData.SetString("scene", "Game_2");
			SaveData.Save ();
			SceneManager.LoadScene ("Game_2");
		}
	}


	void OnTriggerEnter2D(Collider2D collision){
		if (collision.tag == "Player") {
			near_loadscene = true;
		}
	}
	void OnTriggerExit2D(Collider2D collision){
		if (collision.tag == "Player") {
			near_loadscene = false;
		}
	}

}
