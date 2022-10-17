using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Vector3 isMovement;
    public int speed;
    private CharacterController controller;

    void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
    }
    void Update()
    {
        isMovement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(isMovement * speed * Time.deltaTime);
    }
}
