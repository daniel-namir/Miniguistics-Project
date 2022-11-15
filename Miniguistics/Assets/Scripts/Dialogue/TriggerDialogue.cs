using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TriggerDialogue : MonoBehaviour
{
    public Dialogue dialogue;

    public void DialogueTrigger()
    {
        FindObjectOfType<HandleDialogue>().StartDialogue(dialogue);
    }
}