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

	void Update ()
	{
		UpdateStrafe();
		UpdateAttack();
	}

	// INPUTS //

	void UpdateMovement ()
	{
		controller.ReceiveMovement(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
	}

	void UpdateStrafe ()
	{
		controller.ReceiveStrafe(Input.GetButton("Strafe"));
	}

	void UpdateAttack ()
	{
		controller.ReceiveAttack(Input.GetButtonDown("Attack"), Input.GetButtonUp("Attack"));
	}

	void UpdateBlock ()
	{
		// controller.ReceiveBlock(Input.GetButtonDown("Block"), Input.GetButtonUp("Block"));
	}
}
