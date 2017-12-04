using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerscript : MonoBehaviour {

	float flap = 200f;
	bool jump = false;
	Rigidbody2D rigidbody2d;
	Animator animator;
	float speed = 5.0f;

	// Use this for initialization
	void Start () {
		this.rigidbody2d = GetComponent<Rigidbody2D>();
		this.animator = GetComponent<Animator> ();
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
}
