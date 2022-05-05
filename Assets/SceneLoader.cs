using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void loadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void loadMenu1()
    {
        SceneManager.LoadScene(2);
    }

    public void loadLevelMenu()
    {
        SceneManager.LoadScene(3);
    }

    public void loadLastScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex - 1);
    }

    public void loadOptionsMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void closeGame()
    {
        Application.Quit();
    }
}
