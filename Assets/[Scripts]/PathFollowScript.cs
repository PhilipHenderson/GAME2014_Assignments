using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollowScript : MonoBehaviour
{
    [SerializeField]
    private Transform[] points;

    [SerializeField]
    private float speed = 5.0f;

    private int pointIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = points[pointIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (pointIndex <= points.Length - 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, points[pointIndex].transform.position, speed * Time.deltaTime);

            if (transform.position == points[pointIndex].transform.position)
            {
                pointIndex += 1;
            }
        }

    }
}
