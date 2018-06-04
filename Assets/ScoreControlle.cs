using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreControlle : MonoBehaviour {


    public Text scoreText;
    public Text scoreText2;

    void Start()
    {
            
        scoreText.text = "Score 1: " + PlayerPrefs.GetInt("playerScore").ToString();

        scoreText2.text = "Score 2: " + PlayerPrefs.GetInt("playerScore2").ToString();

    }


   
}
