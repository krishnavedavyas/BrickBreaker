using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextManager : MonoBehaviour
{
    public Text scoreText;
    int score = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (score == 6)
        {
            SceneManager.LoadScene("Win");
        }
    }
    public void incrementScore()
    {
        score++;
        scoreText.text = "Score : " + score;
    }
}
