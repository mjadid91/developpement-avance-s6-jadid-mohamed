using UnityEngine.UI;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{
    [SerializeField] private int playerLives = 3;
    [SerializeField] private int score = 0;

    [SerializeField] private TextMeshProUGUI livesText;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI timerText;

    [SerializeField] private Image keyImage;
    [SerializeField] private Sprite noKeySprite;
    [SerializeField] private Sprite keySprite;

    [SerializeField] private GameObject keyIcon;

    private bool hasKey = false;

    private float gameTime = 0f;
    private bool isTimerRunning = true;

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
        UpdateTimerText();

        if (keyIcon != null)
        {
            keyIcon.SetActive(false);
        }
    }

    void Update()
    {
        if (isTimerRunning)
        {
            gameTime += Time.deltaTime;
            UpdateTimerText();
        }
    }

    void UpdateTimerText()
    {
        if (timerText != null)
        {
            timerText.text = "Time: " + FormatTime(gameTime);
        }
    }

    public string GetFormattedTime()
    {
        return FormatTime(gameTime);
    }

    string FormatTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);

        return minutes.ToString("00") + ":" + seconds.ToString("00");
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
        livesText.text = playerLives.ToString();
    }

    void UpdateScoreText()
    {
        scoreText.text = score.ToString();
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

    public void CollectKey()
    {
        Debug.Log("CollectKey appelée");

        hasKey = true;

        if (keyIcon != null)
        {
            Debug.Log("Key Icon trouvé, activation");
            keyIcon.SetActive(true);
        }
        else
        {
            Debug.LogError("Key Icon est NULL dans GameSession");
        }
    }

    public bool HasKey()
    {
        return hasKey;
    }
}