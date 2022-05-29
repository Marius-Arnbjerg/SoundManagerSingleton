using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    [SerializeField] private AudioClip _clip;


    public void StartSound()
    {
        SoundManager.instance.PlayHiHat(_clip);

        Debug.Log("Sound played");
    }
}
