using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplaysUpdate : MonoBehaviour
{
    public Text scoreText;
    public Text itemText;
    public Text timerText;
    private float minutes;
    private float seconds;
    private float fraction;

    void Start()
    {
        //print(Score.score);
    }

    void FixedUpdate()
    {
        scoreText.text = "Score: " + Score.score;
        itemText.text = Score.itemName;

        if (Score.time > 0f)
        {
            Score.time -= Time.deltaTime;
            minutes = Mathf.Floor(Score.time / 60);
            seconds = (Score.time % 60);
            fraction = ((Score.time * 100) % 100);
            timerText.text = "Time Left: " + minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + fraction.ToString("000");
        }
        else
        {
            timerText.text = "";
            Score.itemName = "";
        }
    }
}
