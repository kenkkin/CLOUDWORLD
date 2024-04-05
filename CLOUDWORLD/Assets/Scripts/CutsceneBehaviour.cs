using UnityEngine;
using UnityEngine.SceneManagement;

// make sure scene exists in build settings
public class CutsceneBehaviour : MonoBehaviour
{
    private GameObject _text;

    void Awake()
    {
        _text = GameObject.FindGameObjectWithTag("Skip");
    }

    public void DisableGameObject()
    {
        _text.SetActive(false);
    }

    public void EnableGameObject()
    {
        _text.SetActive(true);
    }

    public void ToggleGameObject()
    {
        if (_text.activeSelf)
            DisableGameObject();
        else
            EnableGameObject();
    }

    void Start()
    {
        Invoke("LoadScene", 16.5f); // delay's the specified function by a certain amount of seconds

        Invoke("EnableGameObject", 1.5f); 
    }

    void LoadScene()
    {
        SceneManager.LoadScene("Village");  
    }

    void Update()
    {
        if (Input.anyKeyDown) // allows for skipable cutscene
        {
            SceneManager.LoadScene("Village"); 
        }
    }
}

