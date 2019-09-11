using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicBehaviour : MonoBehaviour
{
    public GameObject[] Spawnables;
    private GameObject[] Spawners;

    void Awake()
    {
        
    }

    void Start()
    {
        //GameObject spawn1 = GameObject.Find("SpawnPoint (1)");
        Spawners = GameObject.FindGameObjectsWithTag("Spawners");

        foreach (GameObject SpawnObject in Spawners)
        {
            SpawnObject.SetActive(!gameObject.activeSelf);
            Instantiate(Spawnables[0], new Vector3(SpawnObject.transform.position.x, SpawnObject.transform.position.y, SpawnObject.transform.position.z), Quaternion.identity);
        }
        //Spawners.SetActive(!gameObject.activeSelf);
        //print(spawn1.transform.position.x);
        
        //GameObject addCube;
        //addCube = new GameObject("RedCube");
        //addCube.AddComponent<Rigidbody>();
        //addCube.AddComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
