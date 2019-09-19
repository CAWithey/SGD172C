using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillScript : MonoBehaviour
{
    private int Score;
    private void Start()
    {
        Score = 0;
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if (1 == 1) //other.gameObject.tag == "Foods"
        {
            //Score += 1;
            //print(Score);
            //Destroy(other.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Foods") 
        {
            
            Score += 1;
            print(Score);
            Destroy(other.gameObject);
        }
    }
}
