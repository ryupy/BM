using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemImage : MonoBehaviour {
	public static Dictionary<string, Image> image_dict = new Dictionary<string, Image>();

	public Image coffee_image;
	public Image fish_image;
	public Image can_image;

	void Start(){
		image_dict.Add ("Coffee", coffee_image);
		image_dict.Add ("Fish", fish_image);
		image_dict.Add ("Can", can_image);

		coffee_image.enabled = false;
		fish_image.enabled = false;
		can_image.enabled = false;
	}

}
