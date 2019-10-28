using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZoneControllerEssence : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name != "Player1")
            Destroy(gameObject);
    }
}
