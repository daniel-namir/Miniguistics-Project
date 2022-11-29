using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetGame : MonoBehaviour
{
    public GameObject theGame;
    void Update()
    {
        if(theGame.activeInHierarchy == false)
        {
            for (int i = 0; i < 12; i++)
                {
                    theGame.transform.GetChild(i).gameObject.SetActive(true);
                }
        }
    }
}
