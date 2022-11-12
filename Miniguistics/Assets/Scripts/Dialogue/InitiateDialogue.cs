using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitiateDialogue : MonoBehaviour
{
    private string myPartner;
	
    void OnEnable()
    {
        var holder = this.gameObject.GetComponent<DetermineInteraction>();
		myPartner = holder.impacted.name;
    }
    void Update()
    {
        ;
    }
} 