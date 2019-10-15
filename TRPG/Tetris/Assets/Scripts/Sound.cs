using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource GameStart;
    public void PlayGameStart()
    {
        GameStart.Play();
    }
}