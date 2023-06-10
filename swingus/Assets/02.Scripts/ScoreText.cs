using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ScoreText : MonoBehaviour
{
    public TMP_Text textScore;
    public static int scoreValue;

    void Start()
    {
        textScore = GetComponent<TMP_Text>();
    }

    void Update()
    {
        textScore.text = "Score : " + scoreValue;
    }

    void FixedUpdate()
    {
        if(ScoreText.scoreValue == 100)
        {
            SceneManager.LoadScene("wwwwwingus");
        }
    }
}
