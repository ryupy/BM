using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour {

	public Canvas canvasitemget = null;
	
	// Use this for initialization
	void Start () {
		if (canvasitemget != null) {
			canvasitemget.enabled = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (canvasitemget.enabled = true) {
			if (Input.GetKey (KeyCode.DownArrow)) {
				if (canvasitemget != null) {
					canvasitemget.enabled = false;
				}
			}
		}
	}

	void OnTriggerEnter2D(Collider2D collision){
		if (collision.tag == "Player") {
			Destroy (this.gameObject);
			itemget ();
		}
	}

	public void itemget(){
		if (canvasitemget != null) {
			canvasitemget.enabled = true;
		}
	}
}
