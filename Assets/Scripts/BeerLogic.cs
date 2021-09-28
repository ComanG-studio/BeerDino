using System;
using UnityEngine;

public class BeerLogic : MonoBehaviour
{
    private void OnDestroy()
    {
        GameManager.game.AddProgress();
    }
}