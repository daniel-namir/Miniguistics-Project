using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class checkCorrectness : MonoBehaviour
{
    public int score;
    public float endScore;
    public TextMeshProUGUI pass;
    public TextMeshProUGUI finalScore;
    
    public void scoreCount()
    {
        score++;
    }
    
    public void displayScore()
    {
        endScore = (((float)score/5)*100);
        finalScore.text = endScore.ToString() + "%";
        if (score >= 3)
        {
            pass.text = ("You passed! :)");
        }
        else
        {
            pass.text = ("You failed. :(");
        }
    }
}
