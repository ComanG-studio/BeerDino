using System;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager game;


    // ProgressBar logic


    private void Awake()
    {
        InitGameManager();

    }

    [SerializeField] private Image _progressBarFill;
    [SerializeField] private float _maxScore;
    private float _currentScore = 0f;
    public void AddScore()
    {
        // add score to the ProgressBar
        _currentScore += 1f / _maxScore;
        _progressBarFill.transform.localScale = new Vector3(_currentScore, 1f);
    }

    private void InitGameManager()
    {
        if (game == null)
            game = this;
        else if (game != this) Destroy(game);
    }
}