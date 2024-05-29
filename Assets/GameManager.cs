using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] Transform scoreBoard;

    public void RetryButton()
    {
        scoreBoard.GetComponent<ScoreBoard>().resetScore();

        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }

    public void MainMenuButton()
    {
        scoreBoard.GetComponent<ScoreBoard>().resetScore();

        SceneManager.LoadScene("MainMenuScene");
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
