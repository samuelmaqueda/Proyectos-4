﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidosManager : MonoBehaviour
{
	AudioSource audioData;
	public AudioClip[] audios;
	// Start is called before the first frame update
	void Start()
    {
		audioData = GetComponent<AudioSource>();
	}

	public void playBotton()
	{
		audioData.clip = audios[0];
		audioData.Play();
	}
}
