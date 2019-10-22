using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    float _startingForceScalar = 5f;
    Vector3 startingForce;
    public static bool p1 = true;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            startingForce = Vector3.zero;
            startingForce.y = transform.parent.name == "Player1" ? -1 : 1;
            startingForce.x = Random.Range(0, 2) == 0 ? 1 : -1;
            startingForce *= _startingForceScalar;
            transform.SetParent(null);
            GetComponent<Rigidbody>().velocity = startingForce;
        }
    }
    /*public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player1")
            p1 = true;
        else if (other.gameObject.name == "Player2")
            p1 = false;
    }*/
}