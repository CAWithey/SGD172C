using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicBehaviour : MonoBehaviour
{
    public int gameMode = 1;
    public int startTime;
    private int startTime2;
    public GameObject cake;
    public GameObject[] Spawnables;
    private GameObject[] Spawners;
    private GameObject[] Spawners2;
    private int SpawnablesArray;
    private float gameMode2Timer;
    private GameObject CartB1;
    private GameObject CartB2;
    private GameObject[] teleportAreas;

    void Awake()
    {
        Score.time = startTime + 5;
        startTime2 = startTime;
        Score.score = 8000;
        Score.gameMode = gameMode;
        Score.highScore = PlayerPrefs.GetInt("HighScore");
        Score.highScore2 = PlayerPrefs.GetInt("HighScore2");
        gameMode2Timer = 0;
        Spawners = GameObject.FindGameObjectsWithTag("Spawners");
        Spawners2 = GameObject.FindGameObjectsWithTag("Spawners2");
        CartB1 = GameObject.Find("ShoppingCartB (1)");
        CartB2 = GameObject.Find("ShoppingCartB (2)");
        teleportAreas = GameObject.FindGameObjectsWithTag("TeleportArea");

        foreach (GameObject SpawnObject in Spawners)
        {
            SpawnObject.SetActive(false);
        }
        foreach (GameObject SpawnObject2 in Spawners2)
        {
            SpawnObject2.SetActive(false);
        }

        for (int i = 0; i < teleportAreas.Length; i++)
        {
            teleportAreas[i].SetActive(false);
        }

        if (Score.gameMode == 1)
        {
            CartB1.SetActive(false);
            CartB2.SetActive(false);

            var gameMode2KillArea = GameObject.FindGameObjectWithTag("GameMode2KillArea");
            gameMode2KillArea.transform.localPosition = new Vector3(gameMode2KillArea.transform.localPosition.x, y:-10f, gameMode2KillArea.transform.localPosition.z);

            var gameMode2Text = GameObject.FindGameObjectsWithTag("GameMode2Text");
            for (int i = 0; i < gameMode2Text.Length; i++)
            {
                gameMode2Text[i].SetActive(false);
            }

            foreach (GameObject SpawnObject in Spawners)
            {
                SpawnablesArray = Random.Range(0, Spawnables.Length);
                if (Random.Range(0, 10) >= 8) //8
                {
                    Instantiate(Spawnables[Random.Range(0, Spawnables.Length)], new Vector3(SpawnObject.transform.position.x, SpawnObject.transform.position.y, SpawnObject.transform.position.z), Quaternion.Euler(Random.Range(0,259), Random.Range(0, 259), Random.Range(0, 259)));
                }
            }
        }
        else if (Score.gameMode == 2)
        {
            CartB1.SetActive(true);
            CartB2.SetActive(true);

            var gameMode2KillArea = GameObject.FindGameObjectWithTag("GameMode2KillArea");
            gameMode2KillArea.transform.localPosition = new Vector3(gameMode2KillArea.transform.localPosition.x, y:-1.6f, gameMode2KillArea.transform.localPosition.z);

            var gameMode2Text = GameObject.FindGameObjectsWithTag("GameMode2Text");
            for (int i = 0; i < gameMode2Text.Length; i++)
            {
                gameMode2Text[i].SetActive(true);
            }

            for (int i = 0; i < teleportAreas.Length; i++)
            {
                teleportAreas[i].SetActive(true);
            }
        }
        else if (gameMode != 2 && gameMode != 1)
        {
            Score.time = 0;
            var cakeObject = Instantiate(cake, new Vector3(6.642f, 1.79f, 13.262f), Quaternion.Euler(0, 0, 0));
            cakeObject.transform.localScale += new Vector3(1.63f, 1.63f, 1.63f);
            Score.itemName = "Cake!!!!!!!!!!!!!!!!!";

            var gameMode2KillArea = GameObject.FindGameObjectWithTag("GameMode2KillArea");
            gameMode2KillArea.transform.localPosition = new Vector3(gameMode2KillArea.transform.localPosition.x, y: -10f, gameMode2KillArea.transform.localPosition.z);

            var gameMode2Text = GameObject.FindGameObjectsWithTag("GameMode2Text");
            for (int i = 0; i < gameMode2Text.Length; i++)
            {
                gameMode2Text[i].SetActive(false);
            }
        }
    }
    void FixedUpdate()
    {
        if (Score.time > 0f)
        {
            Score.time -= Time.deltaTime;
            Score.minutes = Mathf.Floor(Score.time / 60);
            Score.seconds = (Score.time % 60);
            Score.fraction = ((Score.time * 100) % 100);

            if (Score.gameMode == 1)
            {
                if (Score.time < startTime2 && teleportAreas[1].activeSelf == false)
                {
                    for (int i = 0; i < teleportAreas.Length; i++)
                    {
                        teleportAreas[i].SetActive(true);
                    }
                }
            }

            if (Score.gameMode == 2)
            {
                gameMode2Timer -= Time.deltaTime;
                if (gameMode2Timer <= 0 && Score.time < startTime2)
                {
                    gameMode2Timer = Random.Range(.75f, 2f);

                    var SpawnObject2 = Spawners2[Random.Range(0, Spawners2.Length)];

                    var spawnedObject = Instantiate(Spawnables[Random.Range(0, Spawnables.Length)], new Vector3(SpawnObject2.transform.position.x, SpawnObject2.transform.position.y, SpawnObject2.transform.position.z), Quaternion.Euler(0f, 90f, 0f));
                    var tempAngle = SpawnObject2.transform.localRotation;
                    var tempScale = spawnedObject.transform.localScale.x;
                    spawnedObject.transform.localRotation = tempAngle;
                    //tempScale = Mathf.Clamp(10 / (tempScale + 1f), 1f, 2f);
                    //spawnedObject.transform.localScale = transform.localScale * tempScale;
                    //print(spawnedObject.transform.localScale + " : " + spawnedObject.transform.localScale * tempScale);
                    spawnedObject.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 540f); //560f
                }
            }
        }
        else
        {
            if (Score.gameMode == 1 && Score.score > Score.highScore)
            {
                PlayerPrefs.SetInt("HighScore", Score.score);
            }

            if (Score.gameMode == 2 && Score.score > Score.highScore2)
            {
                PlayerPrefs.SetInt("HighScore2", Score.score);
            }

            var Foods = GameObject.FindGameObjectsWithTag("Foods");
            for (int i = 0; i < Foods.Length; i++)
            {
                Destroy(Foods[i].gameObject);
            }
        }
    }
    void OnApplicationQuit()
    {
        PlayerPrefs.Save();
    }
}
