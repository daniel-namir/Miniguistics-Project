using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
//To Do
//Must do: Make a save where it saves after everytime you talk to someone new/new dialog. 
//Use block collider to trigger an event where if you talk to them, you must interact with another
//script. 
//Make UI for the talking
public class Journal : MonoBehaviour
{
    public GameObject nextPage;
    public GameObject JournalPage;
    public KeyCode J = KeyCode.J;
    public bool difPage = false; //if it's a different page than the journal
    public DataManager dataManager;

    public GameObject englishText; //Object Reference 
    public GameObject koreanText;

    private List<string> listOfWordsEng = new List<string>();
    private List<string> listOfWordsKor = new List<string>();

    void Update()
    {   

        if (Input.GetKeyDown(J) && !difPage)
        {
            Cursor.lockState = CursorLockMode.None;
            JournalPage.SetActive(true);
            difPage = false; 
        }
        loadWords();
    }

    public void nextpage(){
        JournalPage.SetActive(false);
        nextPage.SetActive(true);
        difPage = true;
    }

    public void backPage(){
        JournalPage.SetActive(true);
        nextPage.SetActive(false);
        difPage = true;
    }

    public void backToGame(){
        JournalPage.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        difPage = false;
    }

    public void loadWords()
    {
        listOfWordsKor = dataManager.savedKwords;
        listOfWordsEng = dataManager.savedEwords;
        TextMeshProUGUI textMeshEng = englishText.GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI textMeshKor = koreanText.GetComponent<TextMeshProUGUI>();

        
        string Ewords = "";
        string Kwords = "";

        for(int i = 0; i < listOfWordsEng.Count; i++){
            Ewords += listOfWordsEng[i] + "\n";
        }

        for(int i = 0; i < listOfWordsKor.Count; i++){
            Kwords += listOfWordsKor[i] + "\n";
        }

        textMeshEng.text = Ewords;
        textMeshKor.text = Kwords;
    }

}
