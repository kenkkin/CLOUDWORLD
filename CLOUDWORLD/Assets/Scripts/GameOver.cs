using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject _deathMenu;
    
    public void QuitGame()
    {
        Application.Quit();
        EditorApplication.isPlaying = false;
    }

    public void Menu()
    {
        SceneManager.LoadScene("TitleScreen");
    }
}
