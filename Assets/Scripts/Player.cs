using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Beer"))
        {
            Destroy(other.gameObject);
        }
    }
}