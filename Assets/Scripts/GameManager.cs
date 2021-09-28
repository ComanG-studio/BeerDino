using System;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager game;


    // ProgressBar logic
    [SerializeField] private Image _progressBarFill;
    private float _maxScore = 100f;
    private float _currentScore = 0f;

    private void Awake()
    {
        InitGameManager();
        
    }

    public void AddScore()
    {

    }

    private void InitGameManager()
    {
        if (game == null)
            game = this;
        else if (game != this) Destroy(game);
    }
}