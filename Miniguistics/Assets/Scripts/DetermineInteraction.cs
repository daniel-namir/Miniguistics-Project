using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetermineInteraction : MonoBehaviour
{
    public GameObject impacted;
    public GameObject selectedDest;
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider col)
        {
        impacted = col.gameObject;
        if (impacted.GetComponent<Teleporter>() != null)
        {
            Debug.Log(impacted.ToString());
            selectedDest.SetActive(true);
        }
        if (impacted.GetComponent<isAnimal>() != null)
        {
            ;
        }
    }
    
    public void OnTriggerExit(Collider col)
    { 
        selectedDest.SetActive(false);
    }
}
