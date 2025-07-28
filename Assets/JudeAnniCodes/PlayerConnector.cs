
using UnityEngine;

public class PlayerConnector : MonoBehaviour
{
    [SerializeField] private PlayerHealth playerHealth;
    [SerializeField] private PlayerScore playerScore;
    [SerializeField] private PlayerUIUpdater uiUpdater;

    private void Start()
    {
        uiUpdater.SetMaxHealth(playerHealth.CurrentHealth);
        playerHealth.OnHealthChanged.AddListener(uiUpdater.UpdateHealth);
        playerScore.OnScoreChanged.AddListener(uiUpdater.UpdateScore);
    }
}
