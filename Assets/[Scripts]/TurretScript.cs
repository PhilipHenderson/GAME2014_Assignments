using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript : MonoBehaviour
{
    public Transform target;
    public float range = 15.0f;

    public string Tag = "Enemy";

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("FindTarget", 0.0f, 1.0f);
    }

    void FindTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(Tag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;

        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy > shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        if (nearestEnemy != null && shortestDistance <= range)
        {
            target = nearestEnemy.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            return;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, range);
        Gizmos.color = Color.yellow;
    }
}
