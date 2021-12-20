using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreKeep : MonoBehaviour
{
    private float clock;
    private int score;
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = "Score" + score;
    }

    // Update is called once per frame
    void Update()
    {
        clock += Time.deltaTime;
        
        if (clock > 1f)
        {
            score += 5;
            scoreText.text = score.ToString();
        }
    }
}
