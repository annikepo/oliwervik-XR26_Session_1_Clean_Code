
using UnityEngine;
using System;

public class GameStateController : MonoBehaviour
{
    public bool IsGameOver { get; private set; }

    public event Action OnGameOver;
    public event Action OnWin;

    public void GameOver()
    {
        if (IsGameOver) return;

        IsGameOver = true;
        OnGameOver?.Invoke();
    }

    public void Win()
    {
        if (IsGameOver) return;

        IsGameOver = true;
        OnWin?.Invoke();
    }
}
