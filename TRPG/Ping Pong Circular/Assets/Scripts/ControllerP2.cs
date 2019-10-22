using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerP2 : MonoBehaviour
{
    public GameObject bola;
    float _movementSpeed = 2f;
    Vector3 _deltaPos;
    int golpes = 3;
    public TextMesh Paletas;
    static int _paletas = 4;
    void Update()
    {
        _deltaPos = new Vector3(_movementSpeed * Input.GetAxis("Player2"), 0);
        _deltaPos = Vector3.Lerp(bola.transform.position, gameObject.transform.position, 0.5f);
        _deltaPos.y = transform.position.y;
        transform.RotateAround(Vector3.zero, Vector3.forward, _movementSpeed * Input.GetAxis("Player2") * -1);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Bola")
        {
            golpes -= 1;
            if (golpes == 0)
            {
                _paletas--;
                Paletas.text = _paletas.ToString();
                Destroy(gameObject);
            }
        }
    }
}
