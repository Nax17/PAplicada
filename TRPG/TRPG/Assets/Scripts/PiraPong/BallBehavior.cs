using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    float _startingForceScalar = 5f;
    Vector3 startingForce;
    public SoundManager soundManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && transform.parent != null)
        {
            soundManager.SendMessage("PlayGameStart");
            startingForce = Vector3.zero;
            startingForce.x = transform.parent.name == "Player1" ? -1 : 1;
            startingForce.y = Random.Range(0, 2) == 0 ? 1 : -1;
            startingForce *= _startingForceScalar;
            transform.SetParent(null);
            //GetComponent<Rigidbody>().AddForce(startingForce);
            GetComponent<Rigidbody>().velocity = startingForce;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
            soundManager.SendMessage("PlayPongSound");
    }
}
