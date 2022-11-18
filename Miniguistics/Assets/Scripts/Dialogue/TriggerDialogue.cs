using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TriggerDialogue : MonoBehaviour
{
    public Dialogue dialogue;
	public ParticleSystem teleporter;
	public GameObject areaButton;

    public void DialogueTrigger()
    {
		Debug.Log(teleporter);
		Debug.Log(areaButton);
        FindObjectOfType<HandleDialogue>().StartDialogue(dialogue, teleporter, areaButton);
    }
    
    public void TeleportEnable(ParticleSystem teleport2, GameObject areaButton2)
    {
		Debug.Log(teleport2);
     	teleport2.Play();
		areaButton2.SetActive(true);
    }
}