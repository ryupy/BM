using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class playerscript : MonoBehaviour {
	

//	float flap = 200f;
//	bool jump = false;
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
//		if (Input.GetKeyDown("space") && !jump) {
//			rigidbody2d.AddForce (Vector2.up * flap);
//			jump = true;	
//		}
	}


//	void OnCollisionEnter2D(Collision2D other){
//		if (other.gameObject.CompareTag ("Ground")) {
//			jump = false;
//		}
//	}

	/// <summary>
	/// (Collider2D collision)から(Collider2D c)に変更 
	/// </summary>
	/// <param name="c">C.</param>
	void OnTriggerEnter2D(Collider2D c){
		ItemTrigger (c);
	}


	void ItemTrigger(Collider2D c){
		if (TagUtility.getParentTagName (c.gameObject) == "Item") {
			
			if (TagUtility.getChildTagName(c.gameObject) == "Coffee") {
				Debug.Log (ItemDataBase.items_dict ["Coffee"].item_name);
				ItemDataBase.items_dict ["Coffee"].item_get = true;
				if (ItemDataBase.items_dict ["Coffee"].item_popup_mes) {
					text.GetComponent<MessageManager> ().message = ItemDataBase.items_dict ["Coffee"].item_get_text;
					ItemDataBase.items_dict ["Coffee"].item_image.enabled = true;
					game_director.GetComponent<Game_Directer> ().popup = true;
				}
				Destroy (GameObject.Find ("Item_Coffee"));

			} else if (TagUtility.getChildTagName(c.gameObject) == "Fish") {
				Debug.Log (ItemDataBase.items_dict ["Fish"].item_name);
				ItemDataBase.items_dict ["Fish"].item_get = true;
				if (ItemDataBase.items_dict ["Fish"].item_popup_mes) {
					text.GetComponent<MessageManager> ().message = ItemDataBase.items_dict ["Fish"].item_get_text;
					ItemDataBase.items_dict ["Fish"].item_image.enabled = true;
					game_director.GetComponent<Game_Directer> ().popup = true;
				}
				Destroy (GameObject.Find ("Item_Fish"));

			} else if (TagUtility.getChildTagName(c.gameObject) == "Can") {
				Debug.Log (ItemDataBase.items_dict ["Can"].item_name);
				ItemDataBase.items_dict ["Can"].item_get = true;
				if (ItemDataBase.items_dict ["Can"].item_popup_mes) {
					text.GetComponent<MessageManager> ().message = ItemDataBase.items_dict ["Can"].item_get_text;
					ItemDataBase.items_dict ["Can"].item_image.enabled = true;
					game_director.GetComponent<Game_Directer> ().popup = true;
				}
				Destroy (GameObject.Find ("Item_Can"));
			}
		}
	}
}

