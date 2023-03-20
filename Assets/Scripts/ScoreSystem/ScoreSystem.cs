using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class ScoreSystem : Observer
{
    public TMP_Text scoreText;

    public int currentScore;

    private void Awake()
    {
        currentScore = PlayerPrefs.GetInt("Score");
    }

    private void Start()
    {
        if (scoreText != null)
            scoreText.text = currentScore + "";
    }
   

    public override void OnNotify(int action)
    {
        
       
        currentScore += 100;
        scoreText.text = currentScore.ToString();
        PlayerPrefs.SetInt("Score", currentScore);
    }
}
