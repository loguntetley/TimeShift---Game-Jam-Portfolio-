﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class Sounds
{
    public string name;
    public AudioClip[] _backgroundTrack;

    [Range(0f, 1f)] public float volume;
    [Range(0.1f, 3f)] public float pitch;
}
