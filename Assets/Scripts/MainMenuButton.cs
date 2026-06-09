using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
}