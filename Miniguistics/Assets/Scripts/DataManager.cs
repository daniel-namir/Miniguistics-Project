using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Use System.IO and System when saving and loading data.
using System.IO;
using System;

public class DataManager : MonoBehaviour
{
    [Serializable]
    public class NotebookData{
        public List<string> Kwords;
        public List<string> Ewords;
    }
    

    public List<string> savedKwords = new List<string>();
    public List<string> savedEwords = new List<string>();

    private NotebookData data; //Loaded Data 

    // Start is called before the first frame update
    void Start()
    {
        loadGame();
    }

    public void loadGame(){

        DataDirectoryChecker();
        FileInfo fn = new FileInfo(Application.persistentDataPath + "/Data/GameData.txt" );//Grabs the GameData text file .

        //If the save file exists, then load the json data into the NotebookData (named data) variable.
        if(fn.Exists){
            string json = File.ReadAllText(fn.ToString()); // Converts a file into a string
            data = JsonUtility.FromJson<NotebookData>(json); // convert the json string into a NotebookData variable. (Basically loads the data)

            savedKwords = data.Kwords; //Grabs the list of words into a variable (loadedList).
            savedEwords = data.Ewords;
        } else {
            //If the save file doesn't exist, then create a new save file. 
            CreateNewData();
        }
        Debug.Log(Application.persistentDataPath + "/Data/GameData.txt");
    }

    public void CreateNewData(){
        data = new NotebookData {
            Kwords = new List<string>(),
            Ewords = new List<string>()
        };
        //The true in ToJson is to format the Json file. Without it, all the data will be a single long line.
        string json =  JsonUtility.ToJson(data,true);
        File.WriteAllText(Application.persistentDataPath + "/Data/GameData.txt",json);
    }

    //saves the words of data
    public void SaveGame(){
        data.Kwords = savedKwords;
        data.Ewords = savedEwords; //Replaces the old words with an updated version. 
        string json =  JsonUtility.ToJson(data,true);//Converts notebook data variable into a json string
        File.WriteAllText(Application.persistentDataPath + "/Data/GameData.txt",json);//Using Json, it converts and saves    all the data into a file.
    }

    //If the data folder doesn't exist, then create the data folder.
    public void DataDirectoryChecker(){
        //Directory Path (string)
        string path = Application.persistentDataPath + "/Data";

        //If the directorr (data folder) doesn't exist, then create one. 
        if(!Directory.Exists(path)){
            Directory.CreateDirectory(Application.persistentDataPath + "/Data"); // Creates Directory named Data. 
        }
    }



}

//To make the words unlockable or seen, add new words into a list (savedKwords and savedEwords), and make a reference from the datamanager 
