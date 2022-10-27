using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }
    public void PurchaseTower1()
    {
        Debug.Log("Tower1 Selected");
        buildManager.SetTowerToBuild(buildManager.Tower1Prefab);
    }

    public void PurchaseTower2()
    {
        Debug.Log("Tower2 Selected");
        buildManager.SetTowerToBuild(buildManager.Tower2Prefab);
    }

    public void PurchaseTower3()
    {
        Debug.Log("Tower3 Selected");
        buildManager.SetTowerToBuild(buildManager.Tower3Prefab);
    }
}
