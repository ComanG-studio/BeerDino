using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private ParticleSystem _vomitParticleSystem = null;

    private void OnTriggerEnter(Collider other)
    {
        // if take a beer
        if (other.CompareTag("Beer"))
        {
            Destroy(other.gameObject);
            GameManager.game.AddScore();
        }
    }

    public void Vomit()
    {
        _vomitParticleSystem.Play();
    }
}