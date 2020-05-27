using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using TMPro;

public class GameStatus : MonoBehaviour
{

    [Range(0.1f, 10f)] [SerializeField] float gameSpeed = 1f;
    [SerializeField] int pointsPerBlockDestroyed = 83;
    [SerializeField] TextMeshProUGUI scoreText;

    Block block;

    [SerializeField] int currentScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
        scoreText.text = currentScore.ToString();
    }

    public void AddToScore()
    {
        currentScore += pointsPerBlockDestroyed;
    }

}
