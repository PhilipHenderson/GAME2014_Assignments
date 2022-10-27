using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Creating a count down float that decrease with time
//When it reaches zero, Another wave will Spawn, and the timer will restart to 10 seconds

public class SpawnEnemy : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform spawnPoint;
    public float timeBetweenWaves = 10.0f;
    public float SpawnDelay;
    public Text CurrentLives;
    public Text countDownTxt;
    public Text goldTxt;
    
    public int lives = 20;
    private float countDown = 2.0f;
    public float gold = 0;
    private int waveNumber = 0;

    void Start()
    {
        gold = 10;
    }

    void Update()
    {
        if (countDown <= 0.0f)
        {
            StartCoroutine(SpawnWave());
            countDown = timeBetweenWaves;
        }

        countDown -= Time.deltaTime;

        CurrentLives.text = Mathf.Floor(lives).ToString();
        countDownTxt.text = Mathf.Floor(countDown).ToString();
        goldTxt.text = Mathf.Floor(gold).ToString();


        IEnumerator SpawnWave()
        {
            waveNumber++;

            for (int i = 0; i < waveNumber; i++)
            {
                EnemySpawner();
                yield return new WaitForSeconds(SpawnDelay);
            }
        }

        void EnemySpawner()
        {
            Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
