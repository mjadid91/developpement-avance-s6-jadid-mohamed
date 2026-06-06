using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{
    [SerializeField] private int playerLives = 3;

    void Awake()
    {
        int numberOfGameSessions = FindObjectsByType<GameSession>(FindObjectsSortMode.None).Length;

        if (numberOfGameSessions > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void ProcessPlayerDeath()
    {
        if (playerLives > 1)
        {
            TakeLife();
        }
        else
        {
            ResetGameSessions();
        }
    }

    void TakeLife()
    {
        playerLives--;

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

    void ResetGameSessions()
    {
        SceneManager.LoadScene(0);
        Destroy(gameObject);
    }
}