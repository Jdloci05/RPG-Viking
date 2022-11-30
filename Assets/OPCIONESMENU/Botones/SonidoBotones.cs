using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoBotones : MonoBehaviour
{
    public AudioSource sound;
    public AudioClip soundMenu;
    // Start is called before the first frame update
    public void SoundButtom()
    {
        sound.clip = soundMenu;

        sound.enabled = false;
        sound.enabled = true;
    }
}
