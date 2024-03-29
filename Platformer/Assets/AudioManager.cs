﻿using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public Sound[] sounds;


     void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source=gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }

    void Start()
    {
        Play("Theme");
    }

    public void Play(string name)
    {

        Sound s=Array.Find(sounds, sound => sound.name == name);                                     //ni pominuva niz site sounds i ni go naogja sound so soodvetno ime
       // s.source.Play();

        if(s.source.isPlaying)
        {

        }
        else s.source.Play();
    }

    public void Stop(string name)
    {

        Sound s = Array.Find(sounds, sound => sound.name == name);                                     //ni pominuva niz site sounds i ni go naogja sound so soodvetno ime
                                                                                                       // s.source.Play();

        if (s.source.isPlaying)
        {
            s.source.Stop();
        }
    }
}
