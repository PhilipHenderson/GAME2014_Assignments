using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    public GameObject GMC;
    public GameObject Spawner;

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

    void Update()
    {
        if (PlayerStats.lives <= 0)
        {
            GMC.SetActive(true);
            Spawner.SetActive(false);
        }
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
            buildTiles.SetActive(false);
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
