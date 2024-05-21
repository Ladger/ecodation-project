using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] Transform ground;

    float startZ;
    float score;

    private void Start()
    {
        startZ = ground.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        score = startZ - ground.position.z;

        UpdateScoreboard((int)score);
    }

    void UpdateScoreboard(int in_score)
    {
        scoreText.text = in_score.ToString();
    }
}
