
using UnityEngine;
using UnityEngine.Events;

public class PlayerScore : MonoBehaviour
{
    public UnityEvent<int> OnScoreChanged;

    private int score = 0;

    public void AddScore(int amount)
    {
        score += amount;
        OnScoreChanged?.Invoke(score);
    }

    public int GetScore() => score;
}
