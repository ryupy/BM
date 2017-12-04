using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	GameObject player;
	// Use this for initialization
	void Start () {
		this.player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 playerPos = this.player.transform.position;
		float cam_player_displacement_x = playerPos.x - transform.position.x;
		float trace_length = 3.0f;
		if (cam_player_displacement_x >= trace_length) {
			transform.position = new Vector3 (playerPos.x - trace_length, transform.position.y, transform.position.z);
		} else if (cam_player_displacement_x <= -1*trace_length) {
			transform.position = new Vector3 (playerPos.x + trace_length, transform.position.y, transform.position.z);
		} else {
			transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
		}

	}
}
