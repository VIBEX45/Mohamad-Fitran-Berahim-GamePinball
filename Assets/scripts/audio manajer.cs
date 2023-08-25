using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiomanajer : MonoBehaviour
{

	public AudioSource bgmAudioSource;
	public GameObject sfxAudioSource;

	private void Start()
	{
		// jalankan BGM saat game dimulai
		PlayBGM();
	}
	
	public void PlayBGM() 
	{ 
		bgmAudioSource.Play();
	}

	public void PlaySFX(Vector3 spawnPosition) 
	{ 
		GameObject.Instantiate(sfxAudioSource, spawnPosition, Quaternion.identity);
	}
}