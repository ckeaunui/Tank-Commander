using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    //[SerializeField] private GameObject pauseMenu
     public GameObject Canvas;
     public GameObject Camera;
     bool Paused = false;
 
     void Start(){
         Canvas.gameObject.SetActive (false);
     }
 
     void Update () {
         if (Input.GetKeyDown("escape")) {
             if(Paused == true){
                 Time.timeScale = 1.0f;
                 Canvas.gameObject.SetActive(false);
                 //Camera.GetComponent<AudioSource>().Play ();
                 Paused = false;
             } else {
                 Time.timeScale = 0.0f;
                 Canvas.gameObject.SetActive (true);
                 //Camera.GetComponent<AudioSource>().Pause ();
                 Paused = true;
             }
         }
     }
     public void Resume(){
         Time.timeScale = 1.0f;
         Canvas.gameObject.SetActive (false);
         //Camera.GetComponent<AudioSource>().Play ();
     }
 } 
