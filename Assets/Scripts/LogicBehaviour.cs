using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicBehaviour : MonoBehaviour
{
    public int startTime;
    public GameObject[] Spawnables;
    private GameObject[] Spawners;
    private int SpawnablesArray;

    void Awake()
    {
        //Score.time = startTime;
        Score.time = 9000;
        Score.score = 8000;
        Spawners = GameObject.FindGameObjectsWithTag("Spawners");

        foreach (GameObject SpawnObject in Spawners)
        {
            SpawnObject.SetActive(!gameObject.activeSelf);

            SpawnablesArray = Random.Range(0, Spawnables.Length);
            if (Random.Range(0,10) >= 5)
            {
                Instantiate(Spawnables[Random.Range(0, Spawnables.Length)], new Vector3(SpawnObject.transform.position.x, SpawnObject.transform.position.y, SpawnObject.transform.position.z), Quaternion.Euler(0f,90f,0f));
            }
        }
        //Spawners.SetActive(!gameObject.activeSelf);
        //print(spawn1.transform.position.x);
        
        //GameObject addCube;
        //addCube = new GameObject("RedCube");
        //addCube.AddComponent<Rigidbody>();
        //addCube.AddComponent<BoxCollider>();
    }
}
