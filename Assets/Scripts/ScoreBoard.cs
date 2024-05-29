using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] float scoreFactor;

    float score;


    // Update is called once per frame
    void Update()
    {
        score += scoreFactor * Time.deltaTime;

        UpdateScoreboard((int)score);
    }

    void UpdateScoreboard(int in_score)
    {
        scoreText.text = in_score.ToString();
    }

    public int getScore()
    {
        return (int)score;
    }

    public void resetScore() { score = 0; }
}
