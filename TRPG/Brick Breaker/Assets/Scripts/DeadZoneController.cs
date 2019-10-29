using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZoneController : MonoBehaviour
{
    public TextMesh Vidas;
    public GameObject Barra;
    static int _lives = 3;
    public GameObject bola;
    bool _pierde;
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name != "Bola")
            return;
        _pierde = gameObject.name == "DeadZone";
        //ball.transform.position = new Vector3(0, 0);
        bola.GetComponent<Rigidbody>().velocity = Vector3.zero;
        if (_pierde)
        {
            _lives--;
            if (_lives == 0)
                Application.Quit();
            Vidas.text = _lives.ToString();
            bola.transform.SetParent(Barra.transform);
            bola.transform.localPosition = new Vector3(0, 1.5f);
        }
    }
}
