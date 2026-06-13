using UnityEngine;

public class Key : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Key touchée par : " + other.gameObject.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("Clé ramassée");

            GameSession gameSession = FindAnyObjectByType<GameSession>();

            if (gameSession != null)
            {
                gameSession.CollectKey();
            }

            Destroy(gameObject);
        }
    }
}