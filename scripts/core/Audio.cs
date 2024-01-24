using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public static Audio instance { get; private set; }
    private AudioSource Source;

    private void Awake()
    {
        instance = this;
        Source = GetComponent<AudioSource>();
    }

    public void PlaySound(AudioClip _sound)
    {
        Source.PlayOneShot(_sound);
    }

}
