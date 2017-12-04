using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
					
	}

	void OnTriggerEnter2D(Collider2D collision){
		if (Input.GetKeyDown("space")) {
			Debug.Log ("door2");
//			if (collision.tag == "Player") {
				SceneManager.LoadScene ("test_2");
			}
		}
	}
//}
