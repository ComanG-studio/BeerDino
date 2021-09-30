using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager game;
    [SerializeField] private Image _progressBarFill;
    [SerializeField] private float _maxScore;
    [SerializeField][Range(0f,10f)] private float _currentScore = 0;
    private float _currentFill = 0;

    public float MAXScore
    {
        get => _maxScore;
       private set => _maxScore = value;
    }
    public float CurrentScore
    {
        get => _currentScore;
       private set => _currentScore = value;
    }

    private void Awake()
    {
        InitGameManager();
    }

    public void AddScore()
    {
        // add score to the ProgressBar
        _currentFill += 1f / _maxScore;
        _progressBarFill.transform.localScale = new Vector3(_currentFill, 1f);
        _currentScore += 1f;
    }

    private void InitGameManager()
    {
        if (game == null)
            game = this;
        else if (game != this) Destroy(game);
    }
}