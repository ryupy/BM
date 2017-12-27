using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemDataBase : MonoBehaviour {

	public static Dictionary<string, ItemManager> items_dict = new Dictionary<string, ItemManager>();


	// Use this for initialization
	void Start () {
//		Debug.Log (itemdataflag);
	
			/// Coffee
			string coffee_text = "This is a Coffee.";
//			coffee_image.enabled = false;
		items_dict.Add ("Coffee", new ItemManager ("Coffee", false, true, coffee_text));

			/// Fish
			string fish_text = "This is a Fish. I wonder this is zebrafish.";
//			fish_image.enabled = false;
		items_dict.Add ("Fish", new ItemManager ("Fish", false, true, fish_text));

			/// Can
			string can_text = "This is a Can. This is an empty.";
//			can_image.enabled = false;
		items_dict.Add ("Can", new ItemManager ("Can", false, true, can_text)); 
//			Debug.Log ("aaaa");

//		items.Add (new ItemManager ("Fish",false));
	}
	
	// Update is called once per frame
	void Update () {
	}
}
