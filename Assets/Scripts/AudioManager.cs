using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource introAudioSource;
    public AudioSource normalStateAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        introAudioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (!introAudioSource.isPlaying)
        {
            normalStateAudioSource.Play();

            enabled = false;
        }
    }
}
