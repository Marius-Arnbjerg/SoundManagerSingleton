using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    [SerializeField] private AudioSource _hiHat, _snare, _kick;

    private void Awake()
    {
        instance = this;
            
    }

    public void PlayHiHat(AudioClip clip)
    {
        _hiHat.PlayOneShot(clip);
    }

}
