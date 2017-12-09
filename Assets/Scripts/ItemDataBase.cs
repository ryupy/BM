using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDataBase : MonoBehaviour {
//	public static List<ItemManager> items = new List<ItemManager> (); 
	public static Dictionary<string, ItemManager> items_dict = new Dictionary<string, ItemManager>();
	// Use this for initialization
	void Start () {
		items_dict.Add ("Coffee", new ItemManager("Coffee",false));
//		items.Add (new ItemManager ("Fish",false));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
