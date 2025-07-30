
using UnityEngine;

[RequireComponent(typeof(PlayerHealth), typeof(PlayerScore))]
public class PlayerCollisionHandler : MonoBehaviour
{
    private PlayerHealth playerHealth;
    private PlayerScore playerScore;

    private void Awake()
    {
        playerHealth = GetComponent<PlayerHealth>();
        playerScore = GetComponent<PlayerScore>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Collectible"))
        {
            playerScore.AddScore(10);
            Destroy(collision.gameObject);
            Debug.Log("Collected item!");
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            playerHealth.TakeDamage(10);
            Destroy(collision.gameObject);
            Debug.Log("Hit by enemy!");
        }
    }
}
