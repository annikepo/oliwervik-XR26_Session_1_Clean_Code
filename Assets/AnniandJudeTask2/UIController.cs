
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI gameStatusText;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private Player player;

    private void Start()
    {
        if (gameOverPanel != null)
            gameOverPanel.SetActive(false);
    }

    public void SetStatus(string message)
    {
        if (gameStatusText != null)
            gameStatusText.text = message;
    }

    public void ShowGameOver()
    {
        SetStatus("GAME OVER!");
        if (gameOverPanel != null)
            gameOverPanel.SetActive(true);
    }

    public void ShowWin()
    {
        string msg = "YOU WIN! Score: " + player.GetScore();
        SetStatus(msg);
        if (gameOverPanel != null)
            gameOverPanel.SetActive(true);
    }
}
