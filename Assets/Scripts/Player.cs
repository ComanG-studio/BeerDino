using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private ParticleSystem _vomitParticleSystem;

    private void OnTriggerEnter(Collider other)
    {
        // if take a beer
        if (other.CompareTag("Beer")) Destroy(other.gameObject);
    }

    public void Vomit()
    {
        _vomitParticleSystem.Play();
    }
}