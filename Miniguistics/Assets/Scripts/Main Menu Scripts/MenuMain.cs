using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMain : MonoBehaviour
{
    public GameObject creditCanvas;
    public GameObject mainCanvas;
    public string toScene;
    //Activates this function once you press play. Only the First Frame (1).
    void Start(){
        backToMain();
    }

    public void credits(){
        mainCanvas.SetActive(false);
        creditCanvas.SetActive(true);
    }

    public void backToMain(){
        mainCanvas.SetActive(true);
        creditCanvas.SetActive(false);
    }

    public void goToMainScene(){
        SceneManager.LoadScene(toScene);
    }

    public void quitGame(){
        Application.Quit();
    }
}
