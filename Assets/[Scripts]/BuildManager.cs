using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.Log("2 Build Managers In Scene");
            return;
        }
            instance = this;
    }
    
    public GameObject Tower1Prefab;
    public GameObject Tower2Prefab;
    public GameObject Tower3Prefab;

    private GameObject TowerToBuild;

    public GameObject GetTowerToBuild()
    {
        return TowerToBuild;
    }

    public void SetTowerToBuild(GameObject tower)
    {
        TowerToBuild = tower;
    }
}
