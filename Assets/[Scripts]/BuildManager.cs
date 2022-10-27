using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    public GameObject buildTiles;

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

    public bool HasGold
    {
        get { return PlayerStats.gold >= towerToBuild.cost; }
    }

    public void BuildTowerOn(TileScript tile)
    {
        if (PlayerStats.gold < towerToBuild.cost)
        {
            Debug.Log("Not Enough Moeny");
            return;
        }

        PlayerStats.gold -= towerToBuild.cost;

        GameObject tower = (GameObject)Instantiate(towerToBuild.prefab, tile.GetBuildPosition(), Quaternion.identity);
        tile.tower = tower;

        Debug.Log("Tower Built, Money Left: " + PlayerStats.gold);
        buildTiles.SetActive(false);
    }

    public void SelectTowerToBuild(TowerSettings tower)
    {
        towerToBuild = tower;
    }
}
