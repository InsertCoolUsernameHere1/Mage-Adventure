using UnityEngine;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using System;

public class BulletScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
    