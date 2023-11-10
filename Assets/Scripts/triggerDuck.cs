using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerDuck : MonoBehaviour
{
    public AudioSource MusicPlayer;

    private void OnTriggerEnter(Collider other)
    {
        MusicPlayer.Play();
    }
}
