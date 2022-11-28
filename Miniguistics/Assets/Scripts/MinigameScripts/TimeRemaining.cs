using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeRemaining : MonoBehaviour
{
    public GameObject minigame;
    public GameObject failScreen;
    public GameObject passScreen;
    public TextMeshProUGUI timer;
    public float secondsRemaining;
    public GameObject card1;
    public GameObject card2;
    public bool checkPair1;
    public bool checkPair2;
    public int pairsLeft;
    public int attemptsWrong;

    public void Update()
    {
        if (minigame.activeInHierarchy == true && secondsRemaining >= 0.0f)
        {
            secondsRemaining -= Time.deltaTime;
            timer.text = secondsRemaining.ToString("f2");
        }
        if (pairsLeft <= 0 && secondsRemaining >= 0.0f)
        {
            minigame.SetActive(false);
            passScreen.SetActive(true);
            secondsRemaining = 30.0f;
            attemptsWrong = 0;
        }

        if (attemptsWrong >= 2 || secondsRemaining <= 0)
        {
            minigame.SetActive(false);
            failScreen.SetActive(true);
            secondsRemaining = 30.0f;
            attemptsWrong = 0;
        }
    }

    public void checkPair(GameObject buttonName)
    {
        if (card1 == null)
        {
            card1 = buttonName;
            card1.GetComponent<Button>().interactable = false;
        }
        else if (card1 != null && card2 == null)
        {
            card2 = buttonName;
            card2.GetComponent<Button>().interactable = false;
        }
        if (card1.GetComponent<CardPair>().pairNumber == card2.GetComponent<CardPair>().pairNumber)
        {
            card1.SetActive(false);
            card2.SetActive(false);
            card1.GetComponent<Button>().interactable = true;
            card2.GetComponent<Button>().interactable = true;
            card1 = null;
            card2 = null;
            pairsLeft -= 1;
        }
        else
        {
            attemptsWrong++;
            card1.GetComponent<Button>().interactable = true;
            card2.GetComponent<Button>().interactable = true;
            card1 = null;
            card2 = null;
        }
    }
}