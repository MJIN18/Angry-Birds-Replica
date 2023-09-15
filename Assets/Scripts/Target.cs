using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private int currentCount = 0;

    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            
            Destroy(gameObject);
            if (gameObject.CompareTag("Blue"))
            {
                gameManager.UpdateCount(1);
               
            }
        }

        if(collision.gameObject.CompareTag("Player") && gameObject.CompareTag("Red"))
        {
            Destroy(collision.gameObject);
            gameManager.GameOver();
        }
    }
}
