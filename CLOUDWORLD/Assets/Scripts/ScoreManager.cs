using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class ScoreManager : MonoBehaviour
{
    public float timer;

    public TextMeshProUGUI score;
 
    public TextMeshProUGUI finalScore;

        void Update()
    {
        timer += Time.deltaTime;

        score.text = timer.ToString("Time: " + "0.0");
    }
 
    // public void SaveHighscore(float finalTime)
    // {
    //     PlayerPrefs.GetFloat("Highscore");
    //     finalScore = PlayerPrefs.GetString("Highscore" + "0.0");
    // }
}