using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResolutionController : MonoBehaviour {

	void Awake ()
	{
		Screen.SetResolution(256, 256, false);
	}
}
