using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HandleDialogue : MonoBehaviour
{
	public TextMeshProUGUI dialogueText;
    private Queue<string> words = new Queue<string>();
    public GameObject dialogueBox;

    public void Update()
    {
	    if (Input.GetKeyDown("e"))
	    {
		    DisplayNext();
	    }
    }

    public void StartDialogue (Dialogue dialogue)
	{
		words.Clear();
		foreach (string sentence in dialogue.words)
		{
			words.Enqueue(sentence);
		}
		DisplayNext();
	}
	public void DisplayNext()
	{
		if (words.Count == 0)
		{
			EndDialogue();
			return;
		}
		string sentence = words.Dequeue();
		StopAllCoroutines();
		StartCoroutine(SentenceOutput(sentence));
	}
	IEnumerator SentenceOutput (string sentence){
		dialogueText.text = "";
		foreach (char letter in sentence.ToCharArray()){
			dialogueText.text += letter;
			yield return null;
		}
	}
	public void EndDialogue()
	{
		if (Input.GetKeyDown("e"))
		{
			dialogueBox.SetActive(false);
			FindObjectOfType<TriggerDialogue>().TeleportEnable();
		}
	}
}