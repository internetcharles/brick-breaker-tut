using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    Level level;
    GameStatus gameStatus;

    private void Start()
    {
        level = FindObjectOfType<Level>();
        level.CountBreakableBlocks();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyBlock();
    }

    private void DestroyBlock()
    {
        gameStatus = FindObjectOfType<GameStatus>();
        Destroy(gameObject);
        level.BlockDestroyed();
        gameStatus.AddToScore();
        
    }
}
