using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMixer : MonoBehaviour {

	/// <summary>
	/// UnityEngine.Audio.AudioMixerにしないと、SetFloatが引っ張れない
	/// </summary>
	public UnityEngine.Audio.AudioMixer mixer;

	public void ChangeAudioVolume(float vol){
		mixer.SetFloat ("MusicVolume", vol);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
