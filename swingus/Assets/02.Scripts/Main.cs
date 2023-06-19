using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public GameObject ButtonStart;
    public GameObject ButtonQuit;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            GameQuit();
    }

    public void ButtonStart_Clicked()
    {
        SceneManager.LoadScene("Swingus");
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
