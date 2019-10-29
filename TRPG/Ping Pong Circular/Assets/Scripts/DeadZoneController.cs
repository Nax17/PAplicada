using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZoneController : MonoBehaviour
{
    public TextMesh Vidas1, Vidas2;
    public GameObject[] P1,P2;
    static int _lives1 = 3;
    static int _lives2 = 3;
    public GameObject bola;
    bool _pierde;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name != "Bola")
            return;
        _pierde = gameObject.name == "DeadZone";
        bola.GetComponent<Rigidbody>().velocity = Vector3.zero;
        if (_pierde && Ball.p1 == false)
        {
            _lives1--;
            if (_lives1 == 0)
                Application.Quit();
            Vidas1.text = _lives1.ToString();
            bola.transform.SetParent(P2[0].transform);
            bola.transform.localPosition = new Vector3(0, 0);
        }
        else if (_pierde && Ball.p1 == true)
        {
            _lives2--;
            if (_lives2 == 0)
                Application.Quit();
            Vidas2.text = _lives2.ToString();
            bola.transform.SetParent(P1[0].transform);
            bola.transform.localPosition = new Vector3(0, 0);
        }
    }
}
