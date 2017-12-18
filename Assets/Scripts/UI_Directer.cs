using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Directer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void ui_image_express(){
		GameObject Can_image = new GameObject ("BM_UI_1_4");
		Can_image.transform.parent = GameObject.Find ("Canvasitemget").transform;
		Can_image.AddComponent<RectTransform> ().anchoredPosition = new Vector3 (0, 0, 0);
		Can_image.GetComponent<RectTransform> ().localScale = new Vector3 (1, 1, 1);
		Can_image.AddComponent<Image> ().sprite = Resources.Load<Sprite> ("Resources/Prefabs/BM_UI_1_4");
		Can_image.GetComponent<Image> ().preserveAspect = true;
		Can_image.GetComponent<Image> ().SetNativeSize ();
	}
}
