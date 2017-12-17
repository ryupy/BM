﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class playerscript : MonoBehaviour {
	

	float flap = 200f;
	bool jump = false;
	Rigidbody2D rigidbody2d;
	Animator animator;
	GameObject game_director;
	GameObject text;
	float speed = 5.0f;

//	GameObject item_data_base;
//	ItemDataBase _item_data_base;

	// Use this for initialization
	void Start () {
		this.rigidbody2d = GetComponent<Rigidbody2D>();
		this.animator = GetComponent<Animator> ();
		this.game_director = GameObject.Find ("GameDirecter");
		this.text = GameObject.Find ("Text");
//		item_data_base = GetComponent<ItemDataBase> ();
//		item_data_base.items.Add (new ItemManager ("Fish", false));

	}
	
	// Update is called once per frame
	void Update () {

		int key = 0;
		if (Input.GetKey(KeyCode.LeftArrow)) {
			key = -1;
		}
		if (Input.GetKey(KeyCode.RightArrow)) {
			key = 1;
		}

		if(key != 0){
			transform.localScale = new Vector3 (key, 1, 1);
			this.rigidbody2d.velocity = new Vector2 (key * speed, this.rigidbody2d.velocity.y);
			this.animator.SetBool ("WALK", true);
		}else{
			this.rigidbody2d.velocity = new Vector2 (0, this.rigidbody2d.velocity.y);
			this.animator.SetBool ("WALK", false);
		}

		/// A&&B A=trueかつB=trueで1を返す
		if (Input.GetKeyDown("space") && !jump) {
			rigidbody2d.AddForce (Vector2.up * flap);
			jump = true;	
		}
	}


	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.CompareTag ("Ground")) {
			jump = false;
		}
	}

	void OnTriggerEnter2D(Collider2D collision){
		ItemTrigger (collision);
	}


	void ItemTrigger(Collider2D collision){
		if (collision.tag == "Coffee") {
			Debug.Log (ItemDataBase.items_dict["Coffee"].item_name);
			ItemDataBase.items_dict ["Coffee"].item_get = true;
			if (ItemDataBase.items_dict ["Coffee"].item_popup_mes) {
				text.GetComponent<MessageManager> ().message = ItemDataBase.items_dict ["Coffee"].item_get_text;
				game_director.GetComponent<Game_Directer> ().popup = true;
			}
			Destroy (GameObject.Find("Coffee"));
		} else if(collision.tag == "Fish"){
			Debug.Log (ItemDataBase.items_dict["Fish"].item_name);
			ItemDataBase.items_dict ["Fish"].item_get = true;
			if (ItemDataBase.items_dict ["Fish"].item_popup_mes) {
				text.GetComponent<MessageManager> ().message = ItemDataBase.items_dict ["Fish"].item_get_text;
				game_director.GetComponent<Game_Directer> ().popup = true;
			}
			Destroy (GameObject.Find("Fish"));
		} else {
		}
	}
}

