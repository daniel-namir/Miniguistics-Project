using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportFox : MonoBehaviour
{
    public GameObject player;
    public Vector3 foxPos;
    public GameObject teleDisplay;
    
    public void SetPosition(GameObject warped)
    {
       foxPos = warped.transform.position + new Vector3(5, 0, 5);
       player.GetComponent<CharacterController>().enabled = false;
       TransformFox();
    }
    public void TransformFox()
    {
       player.transform.position = foxPos;
       player.GetComponent<CharacterController>().enabled = true;
       teleDisplay.SetActive(false);
    }
}
