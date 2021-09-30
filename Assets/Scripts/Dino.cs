using System.Security.Cryptography;
using UnityEngine;

public class Dino : MonoBehaviour
{
    [SerializeField] private ParticleSystem _vomitParticleSystem;
    [SerializeField] private ParticleSystem _poisonFX;
    [SerializeField] private Rigidbody2D _vomit;
    [SerializeField] private Transform _vomitSpawnPoint;
    private Rigidbody2D _instantiatedVomit; // for store instantiate object to destroy it after.

    private void Update()
    {
        VomitEngine();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (GameManager.game.CurrentScore == GameManager.game.MAXScore) return;
        // if take a beer
        if (other.CompareTag("Beer"))
        {
            Destroy(other.gameObject);
            GameManager.game.AddScore();
        }
    }

    // NEED TO REFACTOR THIS (or not)
    public void PlayVomit()
    {
        if (_vomitParticleSystem.isPlaying == true) return;
        _vomitParticleSystem.Play();
        _poisonFX.Play();

        // spawn vomit
       _instantiatedVomit = Instantiate(_vomit, _vomitSpawnPoint);
    }

    public void StopVomit()
    {
        if (_vomitParticleSystem.isPlaying == false) return;
        _vomitParticleSystem.Stop();
        _vomitParticleSystem.Clear();
        _poisonFX.Stop();
        _poisonFX.Clear();

        // variant 1 destroy stored instantiate object
        Destroy(_instantiatedVomit.gameObject);

        // variant 2
        //Destroy(GameObject.Find("Name"));
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
    }
}