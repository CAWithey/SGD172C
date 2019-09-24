using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicBehaviour : MonoBehaviour
{
    private float time;
    public float startTime;
    public GameObject[] Spawnables;
    private GameObject[] Spawners;
    private int SpawnablesArray;
    public Text scoreText;
    public Text itemText;
    public Text timerText;

    void Awake()
    {
        
    }

    void Start()
    {
        time = startTime;
        Score.score = 0;
        Spawners = GameObject.FindGameObjectsWithTag("Spawners");
        StartCountdownTimer();

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

    void StartCountdownTimer()
    {
        if (timerText != null)
        {
            timerText.text = "Time: ";
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        //foreach (Text scoreText in Text)
        //{

        //}
        scoreText.text = "Score: " + Score.score;
        itemText.text = Score.itemName;
        if (timerText != null && time > 0f)
        {
            time -= Time.deltaTime;
            string minutes = Mathf.Floor(time / 60).ToString("00");
            string seconds = (time % 60).ToString("00");
            string fraction = ((time * 100) % 100).ToString("000");
            timerText.text = "Time Left: " + minutes + ":" + seconds + ":" + fraction;
        }
        if (time <= 0f)
        {

        }
    }
}
