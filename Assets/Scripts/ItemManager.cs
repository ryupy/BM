using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class ItemManager{
	//item名
	public string item_name;
	//itemを持っているかどうか
	public bool item_get;
	//item取得時にメッセージを表示するかどうか
	public bool item_popup_mes;
	//item取得時のテキスト
	public string item_get_text;
	//item取得時の画像名
	public Image item_image;

	public ItemManager (string name, bool get, bool pop_up_mes, string get_text){
		item_name = name;
		item_get = get;
		item_popup_mes = pop_up_mes;
		item_get_text = get_text;
//		item_image = image;
	}
}
