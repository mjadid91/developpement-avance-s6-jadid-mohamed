using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExit : MonoBehaviour
{
    [SerializeField] private float sceneLoadDelay = 1f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag("Player"))
        {
            return;
        }

        Invoke("LoadNextScene", sceneLoadDelay);
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