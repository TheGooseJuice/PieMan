using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
 public class PauseGame : MonoBehaviour {
 
     public GameObject pauseMenu;
     private bool isEnabled = true;
     public bool paused;

     void Start() {
         paused = true;
         Pause();
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
         }
        

         // disable pause menu
         else if (Input.GetKeyDown(KeyCode.Escape) && isEnabled)
         {
             pauseMenu.SetActive(false);
             isEnabled = false;
             paused = false;
             Pause();
         }
     }
void Pause(){
      if (paused) {
             Time.timeScale = 0;
         }
         if (!paused) {
             Time.timeScale = 1;
         }
    }
 
 }