using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;

    public GameObject buildTiles;

    public TowerSettings Tower1;
    public TowerSettings Tower2;
    public TowerSettings Tower3;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }
    public void SelectTower1()
    {
        Debug.Log("Tower1 Selected");
        buildManager.SelectTowerToBuild(Tower1);
        buildTiles.SetActive(true);
    }

    public void SelectTower2()
    {
        Debug.Log("Tower2 Selected");
        buildManager.SelectTowerToBuild(Tower2);
        buildTiles.SetActive(true);
    }

    public void SelectTower3()
    {
        Debug.Log("Tower3 Selected");
        buildManager.SelectTowerToBuild(Tower3);
        buildTiles.SetActive(true);
    }
}
