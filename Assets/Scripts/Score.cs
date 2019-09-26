using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score;
    public static int highScore;
    public static string itemName;
    public static float minutes;
    public static float seconds;
    public static float fraction;
    public static float time;

    private void Start()
    {
        score = 1234;
    }

    void FixedUpdate()
    {
        if (time > 0f)
        {
            time -= Time.deltaTime;
            minutes = Mathf.Floor(time / 60);
            seconds = (time % 60);
            fraction = ((time * 100) % 100);
        }
    }
}
