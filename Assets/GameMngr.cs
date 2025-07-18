using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMngr : MonoBehaviour
{
    #region Singleton

    public static GameMngr Instance;

    private void Awake()
    {
        if (Instance == null) Instance = this;
    }

    #endregion

    public float currentScore = 0f;

    public bool isPlaying = false;

    public void Update()
    {
        if (isPlaying)
        {
            currentScore += Time.deltaTime;
        }
        if (Input.GetKeyDown("k"))
        {
            isPlaying = true;
        }
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
}

