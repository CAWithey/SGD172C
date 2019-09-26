using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplaysUpdate : MonoBehaviour
{
    public Text scoreText;
    public Text itemText;
    public Text timerText;
    //public int startTime;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        scoreText.text = "Score: " + Score.score;
        itemText.text = Score.itemName;
        if (Score.time <= 0f)
        {
            timerText.text = "Time Left: " + Score.minutes.ToString("00") + ":" + Score.seconds.ToString("00") + ":" + Score.fraction.ToString("000");
        }
        else
        {
            timerText.text = "Time Left: " + Score.minutes.ToString("00") + ":" + Score. seconds.ToString("00") + ":" + Score.fraction.ToString("000");
        }
    }
}
