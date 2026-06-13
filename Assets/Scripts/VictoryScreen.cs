using TMPro;
using UnityEngine;

public class VictoryScreen : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI finalScoreText;
    [SerializeField] private TextMeshProUGUI finalTimeText;

    void Start()
    {
        GameSession gameSession = FindAnyObjectByType<GameSession>();

        if (gameSession != null)
        {
            finalScoreText.text = "Score: " + gameSession.GetScore().ToString();
            finalTimeText.text = "Time: " + gameSession.GetFormattedTime();

            gameSession.HideHUD();
        }

        ScenePersist scenePersist = FindAnyObjectByType<ScenePersist>();

        if (scenePersist != null)
        {
            scenePersist.ResetScenePersist();
        }
    }
}