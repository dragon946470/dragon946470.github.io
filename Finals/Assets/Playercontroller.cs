using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour {
    CharacterController charControl;
    public float walkSpeed;

    private void Awake()
    {
        charControl = GetComponent<CharacterController>();
    }
    private void Update()
    {

    }

    void MovePlayer()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float veritcal = Input.GetAxis("Vertical");

        Vector3 moveDirectionSide = transform.right * horizontal * walkSpeed;
        Vector3 moveDirectionForward = transform.forward * veritcal * walkSpeed;

        charControl.SimpleMove(moveDirectionSide);
        charControl.SimpleMove(moveDirectionForward);
    }
}

