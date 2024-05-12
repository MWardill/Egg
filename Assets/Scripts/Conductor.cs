using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Conductor : MonoBehaviour
{
    public static Conductor Instance;

    public float bpm;
    //public float secPerBeat => 60f / bpm;
    //public float songPositionInBeats => songPosition / secPerBeat;
    public float secPerBeat;
    public float songPositionInBeats;

	public float songPosition;
    
    public float dspSongTime;

    public AudioSource musicSource;
    public TextMeshProUGUI text;

	private void Awake()
	{
        Instance = this;
	}

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

        text.text = $"Beats: {(int)songPositionInBeats}";

    }
}
