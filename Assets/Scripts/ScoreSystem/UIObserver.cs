using SpaceJet.Stats;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public enum ActionData
{
    score,
    swapweapon,

}
public class UIObserver : Observer
{
    [Header("Score")]
    public TMP_Text scoreText;
    public int currentScore;

    [Header("PlayersGun")]
    public List<Image> swapImage = new List<Image>();
    int index = 0;


    private void Awake()
    {
        currentScore = PlayerPrefs.GetInt("Score");

       
    }

    private void Start()
    {
        if (scoreText != null)
            scoreText.text = currentScore + "";
    }


    public override void OnNotify(ActionData action)
    {

        switch (action)
        {
            case ActionData.score:
                currentScore += 100;
                scoreText.text = currentScore.ToString();
                PlayerPrefs.SetInt("Score", currentScore);
                break;
            case ActionData.swapweapon:
                index++;
                index = index >= swapImage.Count ? 0 : index;
                foreach (var item in swapImage)
                {
                    item.color = Color.black;
                }
                swapImage[index].color = Color.white;

                break;

            default:
                break;
        }

    }
}
