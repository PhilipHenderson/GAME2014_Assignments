using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int gold;
    public static int lives;
    public int startGold = 100;
    public int startLives = 20;

    void Start()
    {
        gold = startGold;
        Debug.Log(gold);
        lives = startLives;
        Debug.Log(lives);
    }
}
