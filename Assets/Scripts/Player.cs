using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private ParticleSystem _vomitParticleSystem;
    [SerializeField] private Rigidbody2D _vomit;
    [SerializeField] private Transform _vomitSpawnPoint;

    private void Update()
    {
        VomitEngine();
    }

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
        if (_vomitParticleSystem.isPlaying == true) return;
        _vomitParticleSystem.Play();
        Instantiate(_vomit, _vomitSpawnPoint);
    }

    public void StopVomit()
    {
        if (_vomitParticleSystem.isPlaying == false) return;
        _vomitParticleSystem.Stop();
        _vomitParticleSystem.Clear();
        // How to destroy? Destroy(_vomit);
    }


    /// <summary>
    ///     If dino progress bar is full, he can Vomit
    ///     NEED TO REFACTOR THIS
    /// </summary>
    private void VomitEngine()
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