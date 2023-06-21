using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{ 
    public GameObject ButtonQuit;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            GameQuit();
    }

    public void ButtonQuit_Clicked()
    {
        Application.Quit();
    }

    public void GameQuit()
    {
        Application.Quit();
    }
}
