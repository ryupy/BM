using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageManager : MonoBehaviour {

	public Image UIimage;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	void UIImageDisplay(string command, string imagedir){
//		public Image UIimage;
//		UIimage = GameObject.Find(imagedir).GetComponent<Image> as Image;
		if(command == "show"){
			UIimage.enabled = true;
		}else if(command == "hide"){
			UIimage.enabled = false;
		}
	}
}

