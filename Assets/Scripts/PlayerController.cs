using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// SYSTEM //

	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	// MOVEMENT //

	Rigidbody2D rb;

	public float speed;

	public void ReceiveMovement (float horizontal, float vertical)
	{
		Vector2 movement = GetMovementVector(horizontal, vertical);
		Move(movement);
	}

	Vector2 GetMovementVector (float horizontal, float vertical)
	{
		if (vertical == 1) return Vector2.up;
		if (horizontal == 1) return Vector2.right;
		if (vertical == -1) return Vector2.down;
		if (horizontal == -1) return Vector2.left;
		return Vector2.zero;
	}

	void Move (Vector2 movement)
	{
		rb.AddForce(movement * speed, ForceMode2D.Impulse);
	}
}
