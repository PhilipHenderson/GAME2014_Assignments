using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoints : MonoBehaviour
{
    public static Transform[] points;

    // Gives a list of all the children Waypoints for easy access
    void Awake()
    {
        points = new Transform[transform.childCount];
        for (int i = 0; i < points.Length; i++)
        {
            points[i] = transform.GetChild(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
