using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour {

	bool near = false; 

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.UpArrow) && near) {
			SceneManager.LoadScene ("Title");
		}
	}

	void OnTriggerEnter2D(Collider2D collision){
		if (collision.tag == "Player") {
			near = true;
		}
	}
	void OnTriggerExit2D(Collider2D collision){
		if (collision.tag == "Player") {
			near = false;
		}
	}
}
