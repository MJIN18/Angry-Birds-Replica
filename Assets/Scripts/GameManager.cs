using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI countText;

    public TextMeshProUGUI messageText;

    private int currentCount = 0;

    bool isGameOver = false;

    private void Update()
    {
        if(currentCount == 3 && !isGameOver)
        {
            messageText.text = "Message: You Won!";
        }
    }

    public void UpdateCount(int count)
    {
        if (!isGameOver)
        {
            currentCount += count;
            countText.text = "Count:" + currentCount;
            messageText.text = "Message: Crate destroyed!";
        }
        
    }

    public void GameOver()
    {
        isGameOver = true;
        messageText.text = "Message: Game Over!";
    }
}
