﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{

    public GameManager gameManager;

    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
      
    }

}

