﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// SYSTEM //

	Animator anim;

	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
	}

	// MOVEMENT //

	Rigidbody2D rb;

	public float speed;

	public void ReceiveMovement (float horizontal, float vertical)
	{
		AnimateMovement(GetMovementDirection(horizontal, vertical));
		Move(GetMovementForce(horizontal, vertical));
	}

	Vector2 GetMovementForce (float horizontal, float vertical)
	{
		if (vertical == 1) return Vector2.up;
		if (horizontal == 1) return Vector2.right;
		if (vertical == -1) return Vector2.down;
		if (horizontal == -1) return Vector2.left;
		return Vector2.zero;
	}

	int GetMovementDirection (float horizontal, float vertical)
	{
		if (vertical == 1) return 0;
		if (horizontal == 1) return 1;
		if (vertical == -1) return 2;
		if (horizontal == -1) return 3;
		return -1;
	}

	void AnimateMovement (int direction)
	{
		if (direction < 0)
		{
			anim.SetBool("Moving", false);
		}
		else
		{
			anim.SetBool("Moving", true);
			anim.SetInteger("Direction", direction);
		}
	}

	void Move (Vector2 force)
	{
		rb.AddForce(force * speed, ForceMode2D.Impulse);
	}
}