using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    [SerializeField] private string sceneName;
    
    

    public void Load()
    {
       SceneManager.LoadSceneAsync(sceneName);

       if (sceneName == "ShooterScene")
       {
           Cursor.lockState = CursorLockMode.Locked;  
       }
             
       
        
    }





}
