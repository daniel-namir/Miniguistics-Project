using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetermineInteraction : MonoBehaviour
{
    public GameObject impacted;
    public GameObject selectedDest;
    public GameObject dialogueBox;
	public ParticleSystem teleporter;

    public void OnTriggerEnter(Collider col)
    {
        impacted = col.gameObject;
        if (impacted.GetComponent<Teleporter>() != null && impacted.GetComponent<ParticleSystem>().isPlaying)
        {
            selectedDest.SetActive(true);
        }
        if (impacted.GetComponent<isAnimal>() != null)
        {
            impacted.GetComponent<TriggerDialogue>().DialogueTrigger();
            dialogueBox.SetActive(true);
        }
    }
    
    public void OnTriggerExit(Collider col)
    { 
        selectedDest.SetActive(false);
        dialogueBox.SetActive(false);
    }
}
