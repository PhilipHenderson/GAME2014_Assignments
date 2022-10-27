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
    
    public GameObject tower1Prefab;
    public GameObject tower2Prefab;
    public GameObject tower3Prefab;

    private TowerSettings towerToBuild;

    public bool CanBuild 
    {
        get { return towerToBuild != null; } 
    }

    public void BuildTowerOn(TileScript tile)
    {
        GameObject tower = (GameObject)Instantiate(towerToBuild.prefab, tile.GetBuildPosition(), Quaternion.identity);
        tile.tower = tower;
    }

    public void SelectTowerToBuild(TowerSettings tower)
    {
        towerToBuild = tower;
    }
}
