using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game_Directer : MonoBehaviour {

	public Canvas canvasitemget = null;
	public Canvas canvasitemmenu = null;
	public Canvas canvasconfig = null;
	public bool popup = false;
	private bool popup_now = false;

	// Use this for initialization
	void Start () {
		item_get_win_reverse ();
		item_menu_win_reverse ();
		config_win_reverse ();
	}

	
	// Update is called once per frame
	void Update () {
		if (popup == true) {
			item_get_win_reverse ();
			popup = false;
			popup_now = true;
			Time.timeScale = 0;
		} else if (Input.GetKeyDown (KeyCode.DownArrow) && popup_now == true) {
			Debug.Log ("del");
			item_get_win_reverse ();
			ItemDataBase.items_dict [playerscript.item_name].item_image.enabled = false;
			//ここでplayerscript.item_nameを初期化する
			playerscript.item_name = null;
			popup_now = false;
			Time.timeScale = 1;
		}
	}

	public void Button_MenuDown(){
		item_menu_win_reverse ();
	}

	public void Button_TitleDown(){
		SceneManager.LoadScene ("Title");
	}

	/// <summary>
	/// save buttonが押された時に、セットされているデータをセーブする
	/// </summary>
	public void Button_SaveDown(){
		SaveData.Save ();
		Debug.Log ("success save");
	}


	public void item_get_win_reverse(){
		if (canvasitemget != null) {
			canvasitemget.enabled = !canvasitemget.enabled;
		}
	}

	public void item_menu_win_reverse(){
		if (canvasitemmenu != null) {
			canvasitemmenu.enabled = !canvasitemmenu.enabled;
		}
	}

	public void config_win_reverse(){
		if (canvasconfig != null) {
			canvasconfig.enabled = !canvasconfig.enabled;
		}
	}
}
