﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundary : MonoBehaviour {

	void OnTriggerEnter(Collider col)
	{
		col.GetComponent<basketball> ().ResetPosition ();
		col.GetComponent<basketball> ().DecreaseRemainingBalls ();
		col.GetComponent<basketball> ().ChangeText ();
	}
}
