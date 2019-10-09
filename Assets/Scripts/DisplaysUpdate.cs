using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplaysUpdate : MonoBehaviour
{
    public Text scoreText;
    public Text itemText;
    public Text timerText;

    void FixedUpdate()
    {
        scoreText.text = "Score: " + Score.score;
        itemText.text = Score.itemName;

        if (Score.time > 0f)
        {
            timerText.text = "Time Left: " + Score.minutes.ToString("00") + ":" + Score.seconds.ToString("00") + ":" + Score.fraction.ToString("000");
        }
        else
        {
            timerText.text = "";
            if (Score.gameMode == 1 || Score.gameMode == 2) { Score.itemName = ""; }
            if (Score.gameMode == 1) { itemText.text = "High: " + Score.highScore; }
            if (Score.gameMode == 2) { itemText.text = "High: " + Score.highScore2; }
        }
    }
}
