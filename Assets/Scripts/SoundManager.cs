﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public List<AudioClip> musics;
    public AudioSource musicPlayer;

    public ulong musicBreakCooldown;
    private float currentMusicBreakCooldown;
    
    public AudioClip gameOverClip;
    public AudioSource soundPlayer;

    private bool isStopped = false;

    public void SetStopFlag(bool flag)
    {
        isStopped = flag;
    }

	// Use this for initialization
	void Start () {
        currentMusicBreakCooldown = musicBreakCooldown;
        //PlayNextMusic();
	}
	
	// Update is called once per frame
	void Update () {
        /*if(currentMusicBreakCooldown <= 0)
        {*/

        if (!musicPlayer.isPlaying && !isStopped)
            PlayNextMusic();
        
        //}*/

	}

    void PlayNextMusic()
    {
        musicPlayer.clip = musics[Random.Range(0, musics.Count)];
        musicPlayer.PlayDelayed(musicBreakCooldown);
    }

    public void StopMusic()
    {
        musicPlayer.Stop();
        isStopped = true;
    }

    public void PlayGameOver()
    {
        soundPlayer.clip = gameOverClip;
        soundPlayer.Play();
    }
}
