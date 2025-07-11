using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private void Awake()
    {
        if (Instance == null) Instance = this;
    }

    public float currentScore = 0f;
    public bool isPlaying = true; // Langsung aktif di awal

    private void Update()
    {
        if (isPlaying)
        {
            currentScore += Time.deltaTime;
        }

        // Hapus ini jika tidak perlu manual start:
        // if (Input.GetKeyDown("k"))
        // {
        //     isPlaying = true;
        // }
    }

    public void GameOver()
    {
        currentScore = 0;
        isPlaying = false;
    }

    public string PrettyScore()
    {
        return Mathf.RoundToInt(currentScore).ToString();
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
