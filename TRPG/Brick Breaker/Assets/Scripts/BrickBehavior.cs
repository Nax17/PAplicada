using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickBehavior : MonoBehaviour
{
    public TextMesh Score;
    static int _score;
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bola")
        {
            Destroy(gameObject);
            _score++;
            Score.text = _score.ToString();
        }
    }
}
