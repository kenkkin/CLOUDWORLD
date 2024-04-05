using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

// make sure scene exists in build settings
public class PauseBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenu;
    [SerializeField] private GameObject _pauseButton;

    public void Pause()
    {
        _pauseMenu.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
        EditorApplication.isPlaying = false;
    }

    public void Menu()
    {
        SceneManager.LoadScene("TitleScreen");
    }

    public void PauseButton()
    {
        Time.timeScale = 0.0f;
        _pauseMenu.SetActive(true);
        _pauseButton.SetActive(false);
    }

    public void ResumeButton()
    {
        Time.timeScale = 1.0f;
        _pauseMenu.SetActive(false);
        _pauseButton.SetActive(true);
    }
}