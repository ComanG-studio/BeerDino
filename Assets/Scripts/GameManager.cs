using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager game;
    [SerializeField] private Player _dino;
    [SerializeField] private Image _progressBarFill;
    [SerializeField] private float _maxScore;
    [SerializeField] private float _currentScore = 0;
    public float CurrentScore { get; private set; }

    private void Awake()
    {
        InitGameManager();
    }

    private void Update()
    {
        if (_currentScore >= _maxScore)
        {
            _dino.Vomit();
        }
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
}