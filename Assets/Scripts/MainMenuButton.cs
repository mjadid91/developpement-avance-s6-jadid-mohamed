using UnityEngine;

public class MainMenuButton : MonoBehaviour
{
    public void BackToMainMenu()
    {
        FindAnyObjectByType<GameSession>().ResetGameSessions("StartMenu");
    }
}