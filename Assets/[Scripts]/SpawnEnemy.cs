using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        //startLocation = GetComponent<GameObject>();
        
    }


    // Update is called once per frame
    void Update()
    {
        if (Time.deltaTime % 2 == 0)
        {
            Instantiate(enemy);
        }
    }
}
