using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] ScoreManager ScoreManager;
    public TextMeshProUGUI FinalScore;
    public TextMeshProUGUI HighScore;

    // Update is called once per frame
    void Update()
    {
       
        Highscore();
        Finalscore(); 
    }

    private void Highscore()
    {
        HighScore.text = $"Highscore: {PlayerPrefs.GetInt("HSCORE", 0)}";

    }

    private void Finalscore()
    {
         FinalScore.text = "Final Score:" + ScoreManager.TotalScore.ToString();
    }
}
