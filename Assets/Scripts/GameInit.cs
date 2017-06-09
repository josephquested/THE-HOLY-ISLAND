using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInit : MonoBehaviour {

	// SYSTEM //

	void Awake ()
	{
		Cursor.visible = false;
		Destroy(gameObject);
	}
}
