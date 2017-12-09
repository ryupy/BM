using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class Door : MonoBehaviour {

	GameObject player;
	GameObject to_door;
	bool near = false; 
	public string door_name;
	public string To_door_name;
	static int DOORTIME = 0;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		to_door = GameObject.Find (To_door_name);
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (DOORTIME);
		//ドアフラグ
		if (DOORTIME == 0) {
			if (ItemDataBase.items_dict ["Coffee"].item_get) {
				if (Input.GetKey (KeyCode.UpArrow) && near) {
					player.transform.position = to_door.transform.position;
					DOORTIME = 100;
				}
			}
		}

		if (DOORTIME != 0) {
			DOORTIME -= 1;
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
