using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public float speed;

    private Transform target;
    private int wayPointIndex = 1;

    private void Start()
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
            return;
        }
        wayPointIndex++;
        target = WayPoints.points[wayPointIndex];

    }
}
