using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicBehaviour : MonoBehaviour
{
    public int gameMode = 1;
    //public GameObject Object;
    public int startTime;
    public GameObject[] Spawnables;
    private GameObject[] Spawners;
    private int SpawnablesArray;
    private GameObject CartB1;
    private GameObject CartB2;

    void Awake()
    {
        Score.time = startTime;
        Score.score = 8000;
        Spawners = GameObject.FindGameObjectsWithTag("Spawners");
        CartB1 = GameObject.Find("ShoppingCartB (1)");
        CartB2 = GameObject.Find("ShoppingCartB (2)");

        foreach (GameObject SpawnObject in Spawners)
        {
            SpawnObject.SetActive(false);
        }

        if (gameMode == 1)
        {
            CartB1.SetActive(false);
            CartB2.SetActive(false);

            foreach (GameObject SpawnObject in Spawners)
            {
                SpawnablesArray = Random.Range(0, Spawnables.Length);
                if (Random.Range(0, 10) >= 7)
                {
                    Instantiate(Spawnables[Random.Range(0, Spawnables.Length)], new Vector3(SpawnObject.transform.position.x, SpawnObject.transform.position.y, SpawnObject.transform.position.z), Quaternion.Euler(0f, 90f, 0f));
                }
            }
        }
        else if (gameMode == 2)
        {
            CartB1.SetActive(true);
            CartB2.SetActive(true);

            var teleportAreas = GameObject.FindGameObjectsWithTag("TeleportArea");

            for (int i = 0; i < teleportAreas.Length; i++)
            {
                teleportAreas[i].SetActive(false);
            }
        }
        else if (gameMode != 2 && gameMode != 1)
        {
            print("Error!");
            Score.time = 0;

            foreach (GameObject SpawnObject in Spawners)
            {
                SpawnObject.SetActive(false);
            }
        }
    }
}
