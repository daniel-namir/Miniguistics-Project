using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AttemptsLeft : MonoBehaviour
{
    public int attemptsLeft = 2;
    public TextMeshProUGUI attemptNumber;
    public GameObject currentWrongScreen;
    public GameObject restartScreen;
    // Start is called before the first frame update
    public void reduceAttempt()
    {
        if (attemptsLeft > 1)
        {
            attemptsLeft--;
        }
        else
        {
            endGame();
        }
    }

    public void displayAttempts()
    {
        attemptNumber.text = attemptsLeft.ToString();
    }

    public void endGame()
    {
        currentWrongScreen.SetActive(false);
        restartScreen.SetActive(true);
        attemptsLeft = 2;
    }
}
