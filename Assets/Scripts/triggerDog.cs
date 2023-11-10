using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerDog : MonoBehaviour
{
    public AudioSource MusicPlayer;

    private void OnTriggerEnter(Collider other)
    {
        MusicPlayer.Play();
    }
}
