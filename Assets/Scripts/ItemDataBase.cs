using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDataBase : MonoBehaviour {
	/// <summary>
	/// staticにするとsceneを移動しても破壊されなくなる。
	/// </summary>
	public static Dictionary<string, ItemManager> items_dict = new Dictionary<string, ItemManager>();
	// Use this for initialization
	void Start () {
		string coffee_text = "This is a Coffee";
		items_dict.Add ("Coffee", new ItemManager("Coffee",false,true,coffee_text));
		string fish_text = "This is a Fish";
		items_dict.Add ("Fish", new ItemManager("Fish",false,true,fish_text));

//		items.Add (new ItemManager ("Fish",false));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
