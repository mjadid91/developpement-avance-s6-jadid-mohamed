using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField] private AudioClip pickupSFX;

    private bool wasCollected = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (wasCollected)
        {
            return;
        }

        if (other.CompareTag("Player"))
        {
            wasCollected = true;

            GameSession gameSession = FindAnyObjectByType<GameSession>();

            if (CompareTag("Coin"))
            {
                gameSession.AddToScore();
            }
            else if (CompareTag("Heart"))
            {
                gameSession.AddToLife();
            }

            AudioSource.PlayClipAtPoint(
                pickupSFX,
                Camera.main.transform.position
            );

            Destroy(gameObject);
        }
    }
}