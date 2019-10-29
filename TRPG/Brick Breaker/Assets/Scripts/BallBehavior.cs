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
        if(Input.GetButtonDown("Fire1"))
        {
            soundManager.SendMessage("PlayGameStart");
            startingForce = Vector3.zero;
            startingForce.y = transform.parent.name == "Barra" ? -1 : 1;
            startingForce.x = Random.Range(0, 2) == 0 ? 1 : -1;
            startingForce *= _startingForceScalar;
            transform.SetParent(null);
            GetComponent<Rigidbody>().velocity = startingForce;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" || other.gameObject.tag == "Brick")
            soundManager.SendMessage("PlayClickSound");
    }
}
