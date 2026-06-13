using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExit : MonoBehaviour
{
    [SerializeField] private float sceneLoadDelay = 1f;
    [SerializeField] private bool requiresKey = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }

        GameSession gameSession = FindAnyObjectByType<GameSession>();

        if (requiresKey && (gameSession == null || !gameSession.HasKey()))
        {
            return;
        }

        Invoke(nameof(LoadNextScene), sceneLoadDelay);
    }

    void LoadNextScene()
    {
        ScenePersist scenePersist = FindAnyObjectByType<ScenePersist>();

        if (scenePersist != null)
        {
            scenePersist.ResetScenePersist();
        }

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}