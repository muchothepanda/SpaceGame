using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private int TotalScore;
    [SerializeField] private int HighScore;
    public static ScoreManager singleton;
    public UnityEvent<int> OnTotalScoreChanged = new UnityEvent<int>();
    public UnityEvent<int> OnHighestScoreChangted = new UnityEvent<int>();
    public void IncreaseScore()
    {
        TotalScore += 1;
        OnTotalScoreChanged.Invoke(TotalScore);
    }
    private void Awake()
    {
        singleton=this;
        
    }
    private void Start()
    {
       HighScore=PlayerPrefs.GetInt("HSCORE");
    }
    public void RegisterHighScore()
    {
        if (TotalScore>HighScore)
        {
            PlayerPrefs.SetInt("HSCORE", TotalScore);
            HighScore = TotalScore;
            OnHighestScoreChangted.Invoke(HighScore);
        }
        
    }
    

}
