
using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    public float GameTime { get; private set; } = 0f;
    [SerializeField] private TextMeshProUGUI timerText;

    public void UpdateTimer()
    {
        GameTime += Time.deltaTime;
        if (timerText != null)
        {
            timerText.text = "Time: " + Mathf.FloorToInt(GameTime) + "s";
        }
    }
}
