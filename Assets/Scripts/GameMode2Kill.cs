using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMode2Kill : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Foods" && Score.time > 0 && Score.gameMode == 2)
        {
            Destroy(other.gameObject);
        }
    }
}
