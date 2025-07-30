
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float maxHealth = 30f;
    public UnityEvent<float> OnHealthChanged;
    public UnityEvent OnPlayerDefeated;

    private float currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
        OnHealthChanged?.Invoke(currentHealth);
    }

    public void TakeDamage(float amount)
    {
        currentHealth = Mathf.Max(currentHealth - amount, 0);
        OnHealthChanged?.Invoke(currentHealth);

        if (currentHealth <= 0)
        {
            Debug.Log("Player defeated!");
            OnPlayerDefeated?.Invoke();
        }
    }

    public float CurrentHealth => currentHealth;
}
