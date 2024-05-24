using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScore : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] Transform scoreBoard;

    private void Start()
    {
        int score = scoreBoard.GetComponent<ScoreBoard>().getScore();
        
        scoreText.text = "Score: " + score.ToString();
    }
}
