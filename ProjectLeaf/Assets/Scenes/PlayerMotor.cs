using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour {

    private CharacterController controller;

    private float verticalVelocity;
    private float gravity = 5.5f;
    private float jumpForce = 10.0f;


	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            verticalVelocity = jumpForce;
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }
        Vector3 moveVector = new Vector3(0, verticalVelocity, 0);
        moveVector.x = Input.GetAxis("Horizontal") * 5.0f;
        controller.Move(moveVector * Time.deltaTime);
	}
}
