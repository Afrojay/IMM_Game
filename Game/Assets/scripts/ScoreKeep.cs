using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreKeep : MonoBehaviour
{
    //private float clock;
    public static int score;
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
        score += 1;
            scoreText.text = "Score: " + score.ToString();

    }
}
