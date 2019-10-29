using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject bola;
    float _movementSpeed = 0.7f;
    const float _LOWERLIMIT = -7.27f, _UPPERLIMIT = 7.27f;
    Vector3 _deltaPos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _deltaPos = new Vector3(_movementSpeed * Input.GetAxis("Barra"), 0);
        transform.Translate(_deltaPos);
        _deltaPos = Vector3.Lerp(bola.transform.position, gameObject.transform.position, 0.5f);
        _deltaPos.y = transform.position.y;
        //transform.position = _deltaPos;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, _LOWERLIMIT, _UPPERLIMIT), transform.position.y, transform.position.z);
    }
}
