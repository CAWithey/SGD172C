using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillScript : MonoBehaviour
{
    private void Start()
    {
        Score.score = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Foods") 
        {
            Score.itemName = other.name;
            Score.itemName = Score.itemName.Replace("(Clone)", "");
            if (Score.itemName == "Bananas" || Score.itemName == "Red Apple" || Score.itemName == "Corn" || Score.itemName == "Grapes" || Score.itemName == "Green Apple" || Score.itemName == "Lemon" || Score.itemName == "Orange" || Score.itemName == "Pear" || Score.itemName == "Red Apple" || Score.itemName == "Watermelon" || Score.itemName == "Yellow Apple")
            {
                Score.score += 3;
            }
            else { Score.score += 1; }
            Destroy(other.gameObject);
        }
    }
}
