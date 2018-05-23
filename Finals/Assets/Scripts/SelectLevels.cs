using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLevels : MonoBehaviour
{

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Exited Level");
    }

    public void LevelOne()
    {
        SceneManager.LoadScene("Final Project");
        Debug.Log("Level");
    }

    public void ReturnMenu()
    {
        SceneManager.LoadScene("Main Menu");
        Debug.Log("return");
    }

    public void CreditsYes()
    {
        SceneManager.LoadScene("Credit");
        Debug.Log("THE PEOPLE WHO MADE THE GAME");
    }

    public void Newsworthy()
    {
        SceneManager.LoadScene("News");
        Debug.Log("Read this");
    }
}
