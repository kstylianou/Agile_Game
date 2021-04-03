﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{

    public Button UpdateScene;

    public string sceneName;
    public string previus;

    public void LoadNewScene(string sceneName)
    {
        //SceneManager.UnloadScene(previus);
        SceneManager.LoadScene(sceneName);
        Debug.Log("Clicked");
    }

    void Start()
    {
        Button btn = UpdateScene.GetComponent<Button>();

        btn.onClick.AddListener(() => LoadNewScene(sceneName));
    }
}