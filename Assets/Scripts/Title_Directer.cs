using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Title_Directer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	/// <summary>
	/// buildsettingに入れておかないとloadできない
	/// </summary>
	public void Button_StartDown(){
		ItemImage.image_dict.Clear ();
		SceneManager.LoadScene ("Game_1");
	}

	public void Button_LoadDown(){
//		string scene_name = SaveData.GetString("scene", "Game_1");
//		SceneManager.LoadScene (scene_name);
	}


}
