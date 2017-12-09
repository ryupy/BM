using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemManager{

	public string item_name;
	public bool item_get;

	public ItemManager(string name,bool get){
		item_name = name;
		item_get = get;
	}
}
