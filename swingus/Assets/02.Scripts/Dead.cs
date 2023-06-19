using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    public GameObject Panel;
    public GameObject ButtonQuit;
    public GameObject ButtonPoop;

    void Start()
    {
        Panel.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            GameQuit();
    }

    public void ButtonPoop_Clicked()
    {
        Panel.SetActive(true);
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
