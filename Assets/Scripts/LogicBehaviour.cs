using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicBehaviour : MonoBehaviour
{
    public int gameMode = 1;
    public int startTime;
    public GameObject[] Spawnables;
    private GameObject[] Spawners;
    private int SpawnablesArray;

    void Awake()
    {
        Score.time = startTime;
        Score.score = 8000;
        Spawners = GameObject.FindGameObjectsWithTag("Spawners");

        if (gameMode == 1)
        {
            foreach (GameObject SpawnObject in Spawners)
            {
                SpawnObject.SetActive(!gameObject.activeSelf);
            }

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
            foreach (GameObject SpawnObject in Spawners)
            {
                Destroy(SpawnObject);
            }

            var rawr = GameObject.FindGameObjectsWithTag("TeleportArea");

            for (int i = 0; i < rawr.Length; i++)
            {
                rawr[i].SetActive(false);
            }
        }
        else if (gameMode != 2 && gameMode != 1)
        {
            print("Error!");
            Score.time = 0;

            foreach (GameObject SpawnObject in Spawners)
            {
                Destroy(SpawnObject);
            }
        }
    }
}
