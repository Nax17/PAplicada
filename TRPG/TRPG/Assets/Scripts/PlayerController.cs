using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject ball;
    bool _cpuPlayer = false;
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
        if (_cpuPlayer == false || _isPlayerOne)
        {
            _deltaPos = new Vector3(0, _movementSpeed * Input.GetAxis(_isPlayerOne ? "Player1" : "Player2"));
            transform.Translate(_deltaPos);
        }
        else if(!_isPlayerOne && ball != null)
        {
            _deltaPos = Vector3.Lerp(ball.transform.position, gameObject.transform.position, 0.5f);
            _deltaPos.x = transform.position.x;
            transform.position = _deltaPos;
        }
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, _LOWERLIMIT, _UPPERLIMIT), transform.position.z);
    }
}
