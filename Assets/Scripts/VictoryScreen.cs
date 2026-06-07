using TMPro;
using UnityEngine;

public class VictoryScreen : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI finalScoreText;

    void Start()
    {
        GameSession gameSession = FindAnyObjectByType<GameSession>();

        if (gameSession != null)
        {
            finalScoreText.text = "Score: " + gameSession.GetScore().ToString();
            gameSession.HideHUD();
        }

        ScenePersist scenePersist = FindAnyObjectByType<ScenePersist>();

        if (scenePersist != null)
        {
            scenePersist.ResetScenePersist();
        }
    }
}