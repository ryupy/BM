using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bikkuri_Manager : MonoBehaviour {

	GameObject player;
	public static bool itemflag = false;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");

	}
	
	// Update is called once per frame
	void Update () {
		Vector3 playerPos = this.player.transform.position;
		if (playerscript.key == 1) {
			transform.position = new Vector3 (playerPos.x + 1.5f, playerPos.y + 2.0f, 0.0f);
		} else if (playerscript.key == -1) {
			transform.position = new Vector3 (playerPos.x - 1.5f, playerPos.y + 2.0f, 0.0f);
		}

		if (itemflag == false) {
			Destroy (gameObject);
		}
	}
}
