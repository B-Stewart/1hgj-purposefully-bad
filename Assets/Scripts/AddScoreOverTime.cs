using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScoreOverTime : MonoBehaviour
{
    public int ScorePerSecond = 1;
    public Text VisualScore;

	// Use this for initialization
	void Start ()
    {
        InvokeRepeating("AddScore", 0, 1.0f);
	}
	
	void AddScore()
    {
        GameInformation.Score += ScorePerSecond;
        if(VisualScore)
            VisualScore.text = GameInformation.Score.ToString();
    }
}
