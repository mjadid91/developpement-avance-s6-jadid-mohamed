using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{
    [SerializeField] private int playerLives = 3;
    [SerializeField] private int score = 0;

    [SerializeField] private TextMeshProUGUI livesText;
    [SerializeField] private TextMeshProUGUI scoreText;

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

    void Start()
    {
        UpdateLivesText();
        UpdateScoreText();
    }

    public void ProcessPlayerDeath()
    {
        if (playerLives > 1)
        {
            TakeLife();
        }
        else
        {
            ResetGameSessions("GameOver");
        }
    }

    void TakeLife()
    {
        playerLives--;
        UpdateLivesText();

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void ResetGameSessions(string sceneName)
    {
        ScenePersist scenePersist = FindAnyObjectByType<ScenePersist>();

        if (scenePersist != null)
        {
            scenePersist.ResetScenePersist();
        }

        SceneManager.LoadScene(sceneName);
        Destroy(gameObject);
    }

    public void AddToLife()
    {
        playerLives++;
        UpdateLivesText();
    }

    public void AddToScore()
    {
        score += 100;
        UpdateScoreText();
    }

    void UpdateLivesText()
    {
        livesText.text = "Lives: " + playerLives.ToString();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public int GetScore()
    {
        return score;
    }

    public void HideHUD()
    {
        if (livesText != null)
        {
            livesText.transform.parent.gameObject.SetActive(false);
        }
    }
}