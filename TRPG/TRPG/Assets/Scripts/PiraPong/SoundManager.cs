using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource PongSound;
    public AudioSource GameStart;
    public AudioSource ScoreSent;
    public void PlayPongSound()
    {
        PongSound.Play();
    }
    public void PlayGameStart()
    {
        GameStart.Play();
    }
    public void PlayScoreSent()
    {
        ScoreSent.Play();
    }
}
