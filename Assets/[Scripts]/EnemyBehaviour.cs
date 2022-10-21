using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyBehaviour : MonoBehaviour
{
    SpawnEnemy enemies;
    public float speed;
    public GameObject enemy;

    private Transform target;
    private int wayPointIndex = 1;

    void Awake()
    {
        enemies = enemy.GetComponent<SpawnEnemy>();    
    }

    void Start()
    {
        target = WayPoints.points[0];
    }

    void Update()
    {
        Vector2 direction = target.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);

        if (Vector2.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWayPoint();
        }
    }

    private void GetNextWayPoint()
    {

        if (wayPointIndex >= WayPoints.points.Length - 1)
        {
            Destroy(gameObject);
            if (enemies != null)
            {
                Debug.Log("Decreasing enemies");
                enemies.enemies--;
            }
            return;
        }
        wayPointIndex++;
        target = WayPoints.points[wayPointIndex];

    }
}
