﻿using UnityEngine;
using System.Collections;

public class PlaySound : MonoBehaviour {

	private bool playSound = false;
	[SerializeField]
	private AudioSource ratSound;

	void Update () {
		if (playSound == true) {
			ratSound.Play ();
		}
	}

	void OnBecameVisible()
	{
		playSound = true;
	}
}
