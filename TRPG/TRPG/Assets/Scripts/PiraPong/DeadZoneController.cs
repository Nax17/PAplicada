using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZoneController : MonoBehaviour
{
    public TextMesh P1Text, P2Text;
    public GameObject P1, P2;
    static int _score1, _score2;
    public GameObject ball;
    bool _p1Score;
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name != "Bola")
            return;
        _p1Score = gameObject.name == "P2DeadZone";
        //ball.transform.position = new Vector3(0, 0);
        ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
        if (_p1Score)
        {
            _score1++;
            P1Text.text = _score1.ToString();
            ball.transform.SetParent(P1.transform);
            ball.transform.localPosition = new Vector3(1, 0);
        }
        else
        {
            _score2++;
            P2Text.text = _score2.ToString();
            ball.transform.SetParent(P2.transform);
            ball.transform.localPosition = new Vector3(-1, 0);
        }
    }
}
