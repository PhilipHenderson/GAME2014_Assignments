using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    public Color hoverColer;
    public Vector3 offset;

    [Header("Optional")]
    public GameObject tower;

    public GameObject buildTiles;

    private Renderer rend;
    private Color startColor;

    BuildManager buildManager;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

        buildManager = BuildManager.instance;
    }

    public Vector3 GetBuildPosition()
    {
        return transform.position + offset;
    }

    void OnMouseDown()
    {
        if (!buildManager.CanBuild)
            return;
        
        if (tower != null)
        {
            Debug.Log("Turret already there"); 
            return;
        }

        buildManager.BuildTowerOn(this);
    }

    void OnMouseEnter()
    {
        if(!buildManager.CanBuild) 
            return;
        GetComponent<Renderer>().material.color = hoverColer;
    }

    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = startColor;
    }
}
