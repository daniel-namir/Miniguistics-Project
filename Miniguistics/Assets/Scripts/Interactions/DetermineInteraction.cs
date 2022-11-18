using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetermineInteraction : MonoBehaviour
{
    public GameObject impacted;
    public GameObject selectedDest;
    public GameObject dialogueBox;
	public ParticleSystem teleporter;
    public GameObject stage0;
	public GameObject stage1;
	public GameObject stage2;
	public GameObject stage3;
	public GameObject stage4;
	public GameObject stage5;

    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider col)
        {
        impacted = col.gameObject;
        if (impacted.GetComponent<Teleporter>() != null && impacted.GetComponent<ParticleSystem>().isPlaying)
        {
            Debug.Log(impacted);
            selectedDest.SetActive(true);
        }
        if (impacted.GetComponent<isAnimal>() != null)
        {
            impacted.GetComponent<TriggerDialogue>().DialogueTrigger();
            Debug.Log(impacted);
            dialogueBox.SetActive(true);
        }
        if (impacted.GetComponent<IsMinigame>() != null)
        {
		   Debug.Log(impacted);
        }
    }
    
    public void OnTriggerExit(Collider col)
    { 
        selectedDest.SetActive(false);
        dialogueBox.SetActive(false);
    }
}
