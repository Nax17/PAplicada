using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    bool _isPlayerOne;
    float _movementSpeed = 1f;
    const float _LOWERLIMIT = -3.455f, _UPPERLIMIT = 3.455f;
    Vector3 _deltaPos;
    // Start is called before the first frame update
    void Start()
    {
        _isPlayerOne = name == "Player1";
    }

    // Update is called once per frame
    void Update()
    {
        _deltaPos = new Vector3(0, _movementSpeed * Input.GetAxis(_isPlayerOne ? "Player1" : "Player2"));
        transform.Translate(_deltaPos);
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, _LOWERLIMIT, _UPPERLIMIT), transform.position.z);
    }
}
