using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillScript : MonoBehaviour
{
    private void Awake()
    {
        Score.score = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Foods" && Score.time > 0) 
        {
            Score.itemName = other.name;
            Score.itemName = Score.itemName.Replace("(Clone)", "");
            if (Score.gameMode == 1)
            {
                if (Score.itemName == "Bananas" || Score.itemName == "Red Apple" || Score.itemName == "Corn" || Score.itemName == "Grapes" || Score.itemName == "Green Apple" || Score.itemName == "Lemon" || Score.itemName == "Orange" || Score.itemName == "Pear" || Score.itemName == "Red Apple" || Score.itemName == "Watermelon" || Score.itemName == "Yellow Apple" || Score.itemName == "Broccoli")
                {
                    Score.score += 3;
                }
                else if (Score.itemName == "Fish")
                {
                    Score.score += 2;
                }
                else if (Score.itemName == "Lotion" || Score.itemName == "Sake" || Score.itemName == "Angry Orchard")
                {
                    Score.score -= 0;
                }
                else { Score.score += 1; }
            }
            if (Score.gameMode == 2)
            {
                if (name == "gameMode2KillAreaRight")
                    if (Score.itemName == "Bananas" || Score.itemName == "Red Apple" || Score.itemName == "Corn" || Score.itemName == "Grapes" || Score.itemName == "Green Apple" || Score.itemName == "Lemon" || Score.itemName == "Orange" || Score.itemName == "Pear" || Score.itemName == "Red Apple" || Score.itemName == "Watermelon" || Score.itemName == "Yellow Apple" || Score.itemName == "Broccoli")
                    {
                        Score.score += 1;
                    }
                if (name == "gameMode2KillAreaLeft")
                    if (Score.itemName != "Bananas" && Score.itemName != "Red Apple" && Score.itemName != "Corn" && Score.itemName != "Grapes" && Score.itemName != "Green Apple" && Score.itemName != "Lemon" && Score.itemName != "Orange" && Score.itemName != "Pear" && Score.itemName != "Red Apple" && Score.itemName != "Watermelon" && Score.itemName != "Yellow Apple" && Score.itemName != "Broccoli")
                    {
                        Score.score += 1;
                    }
            }
            Destroy(other.gameObject);
        }
    }
}
