using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
 public class PauseGame : MonoBehaviour {
 
     public GameObject pauseMenu;
     public bool isEnabled = false;
     public bool paused;

    public AudioSource m_audio;
     void Start() {
         paused = false;
     }
     void Update()
     {
         // Enable pause menu
         if (Input.GetKeyDown(KeyCode.Escape) && !isEnabled)
         {
             pauseMenu.SetActive(true);
             isEnabled = true;
             paused = !paused;
             Pause ();
             m_audio.Stop();
         }
        

         // disable pause menu
         else if (Input.GetKeyDown(KeyCode.Escape) && isEnabled)
         {
             pauseMenu.SetActive(false);
             isEnabled = false;
             paused = false;
             Pause();
             m_audio.Play();
         }
     }
public void Pause(){
      if (paused) {
             Time.timeScale = 0;
         }
         if (!paused) {
             Time.timeScale = 1;
         }
    }
 
 }