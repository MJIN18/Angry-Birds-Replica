using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI countText;

    public TextMeshProUGUI messageText;

    private int count = 0;

    bool isGameOver = false;

    private void Update()
    {
        if(count == 3 && !isGameOver)
        {
            messageText.text = "You Won!";
        }
    }

    public void UpdateCount(int count)
    {
        if (!isGameOver)
        {
            count += count;
            countText.text = "Count:" + count;
            messageText.text = "Message: Crate destroyed!";
        }
        
    }

    public void GameOver()
    {
        isGameOver = true;
        messageText.text = "Message: Game Over!";
    }
}
