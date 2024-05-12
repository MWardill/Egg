using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conductor : MonoBehaviour
{
    public float bpm;
    //public float secPerBeat => 60f / bpm;
    //public float songPositionInBeats => songPosition / secPerBeat;
    public float secPerBeat;
    public float songPositionInBeats;

	public float songPosition;
    
    public float dspSongTime;

    public AudioSource musicSource;

    
    void Start()
    {
		secPerBeat = 60f / bpm;
		musicSource = GetComponent<AudioSource>();        
        dspSongTime = (float)AudioSettings.dspTime;
        musicSource.Play();
    }
    
    void Update()
    {
        songPosition = (float)(AudioSettings.dspTime - dspSongTime);
        songPositionInBeats = songPosition / secPerBeat;

	}
}
