using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicStop : MonoBehaviour {

	public AudioSource m_audio;
	

	// Use this for initialization
	public void RemoveAudio () {
		m_audio.Stop();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
