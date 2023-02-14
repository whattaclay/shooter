using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonScript : MonoBehaviour
{
    [SerializeField] private string sceneName;
    private string ShooterScene;
    

    public void Load()
    {
        SceneManager.LoadSceneAsync(sceneName);
    }





}
