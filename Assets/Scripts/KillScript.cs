using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillScript : MonoBehaviour
{
    private int Score;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Foods")
        {
            Destroy(other.gameObject);
            Score = Score + 1;
            print(Score);
        }
    }
}
