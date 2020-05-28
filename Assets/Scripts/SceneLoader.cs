using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    GameStatus gameStatus;
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
    public void LoadFirstScene()
    {
        SceneManager.LoadScene(0);
        gameStatus = FindObjectOfType<GameStatus>();
        gameStatus.ResetScore();
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
}
