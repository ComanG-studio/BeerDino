using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager game;
    [SerializeField] private Player _dino;
    [SerializeField] private Image _progressBarFill;
    [SerializeField] private float _maxScore;
    private float _currentScore = 0;
    public float CurrentScore { get; private set; }

    private void Awake()
    {
        InitGameManager();
    }

    private void Update()
    {
        VomitPermission();
    }

    public void AddScore()
    {
        // add score to the ProgressBar
        CurrentScore += 1f / _maxScore;
        _progressBarFill.transform.localScale = new Vector3(CurrentScore, 1f);
        _currentScore += 1f;
    }

    private void InitGameManager()
    {
        if (game == null)
            game = this;
        else if (game != this) Destroy(game);
    }

    /// <summary>
    /// If dino progress bar is full, he can Vomit
    /// NEED TO REFACTOR THIS
    /// </summary>
    private void VomitPermission()
    {
        if (_currentScore >= _maxScore)
        {
            _dino.PlayVomit();
        }
        else if (_currentScore < _maxScore)
        {
            _dino.StopVomit();
        }
    }
}