using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource ClickSound;
    public AudioSource GameStart;
    public void PlayClickSound()
    {
        ClickSound.Play();
    }
    public void PlayGameStart()
    {
        GameStart.Play();
    }
}
