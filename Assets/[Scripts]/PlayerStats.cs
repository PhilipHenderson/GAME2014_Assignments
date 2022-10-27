using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int gold;
    public int startGold = 100;

    void Start()
    {
        gold = startGold;
        Debug.Log(gold);
    }
}
