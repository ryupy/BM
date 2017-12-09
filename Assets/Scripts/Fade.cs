using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Fade : MonoBehaviour {
	public float alpha;
	float red,green,blue;
	float speed = 0.005f;
	// Use this for initialization
	void Start () {
		red = GetComponent<Image> ().color.r;
		green = GetComponent<Image> ().color.g;
		blue = GetComponent<Image> ().color.b;

	}
	
	// Update is called once per frame
	void Update () {
		if (alpha > 0) {
			GetComponent<Image>().color = new Color (red, green, blue, alpha);
			alpha -= speed;
		}
		
	}
}
