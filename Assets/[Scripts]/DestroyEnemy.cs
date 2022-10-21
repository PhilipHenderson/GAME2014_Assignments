using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    public void OnCollisionEnter2D(other)
    {
        Destroy(other.gameObject);  
    }
}
