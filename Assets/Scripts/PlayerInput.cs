using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

	// SYSTEM //

	PlayerController controller;

	void Start ()
	{
		controller = GetComponent<PlayerController>();
	}

	void FixedUpdate ()
	{
		UpdateMovement();
	}

	// INPUTS //

	void UpdateMovement ()
	{
		controller.ReceiveMovement(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
	}
}
