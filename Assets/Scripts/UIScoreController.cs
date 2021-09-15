using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScoreController : MonoBehaviour
{
    [Header("UI")]
    public Text score;
    public Text highScore;

    [Header("Score")]
    public ScoreController scoreController;

    private void Update()
    {
        score.text = "SCORE : " + scoreController.GetCurrentScore().ToString();
        highScore.text = "BEST     : " + ScoreData.highScore.ToString();
    }
}
