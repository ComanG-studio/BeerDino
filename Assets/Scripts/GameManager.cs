using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager game;
    private float _score;
    [SerializeField] private Image _progressBar;

    private void Awake()
    {
        initGameManager();
    }

    /// <summary>
    /// Add score to the ProgressBar
    /// </summary>
    private void AddProgress()
    {
        // add score to the ProgressBar
        _score += 1f;
        _progressBar.transform.localScale = new Vector3(_score, 1f);
    }

    private void initGameManager()
    {
        if (game == null)
            game = this;
        else if (game != this) Destroy(game);
    }
}