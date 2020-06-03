using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicainico : MonoBehaviour
{
	AudioSource audioData;
	public AudioClip[] audios;
	// Start is called before the first frame update
	void Start()
    {
		audioData = GetComponent<AudioSource>();
		audioData.clip = audios[0];
		audioData.Play();
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
