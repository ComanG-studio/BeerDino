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

    public void PlayVomit()
    {
        _vomitParticleSystem.Play();
    }

    public void StopVomit()
    {
        _vomitParticleSystem.Stop();
        _vomitParticleSystem.Clear();
    }

    /// <summary>
    /// If dino progress bar is full, he can Vomit
    /// NEED TO REFACTOR THIS
    /// </summary>
    private void VomitPermission()
    {
        if (GameManager.game.CurrentScore >= GameManager.game.MAXScore)
        {
            PlayVomit();
        }
        else if (GameManager.game.CurrentScore < GameManager.game.MAXScore)
        {
            StopVomit();
        }
    }
}