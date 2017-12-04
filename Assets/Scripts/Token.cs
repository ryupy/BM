using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Token : MonoBehaviour {


	/// 消滅（メモリから削除）
	public void DestroyObj ()
	{
		Destroy (gameObject);
	}
}