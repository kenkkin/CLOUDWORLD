using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;

public class GameBehaviour : MonoBehaviour
{
    public static GameBehaviour Instance;

    public Transform player;

    private GameObject enemies;

    public ScoreManager scoring;
    private TextMeshProUGUI finalScore;

    void Awake() //initialised in Awake as opposed to Start because it will initialise first, before start and only once. This gives GameBehaviour priority over GameObjects
    {
        // singleton pattern: enforces a single reference to the instance 
        if  (Instance != null && Instance != this)
            Destroy (this);
        else 
            Instance = this;

        enemies = GameObject.FindGameObjectWithTag("Enemy");
    }

    void Update () {
        transform.position = player.transform.position + new Vector3(0, 1, -5);

        if (enemies == null)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
