using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieBehaviour : MonoBehaviour {

	
	// Use this for initialization
     public AudioClip deathSound;
     private AudioSource m_Daudio;
 
 
     void Update()
     {
 
    m_Daudio.Play();
    }
}