using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    public Color hoverColer;
    public Vector3 offset;

    private GameObject turret;

    private Renderer rend;
    private Color startColor;

    BuildManager buildManager;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

        buildManager = BuildManager.instance;
    }

    void OnMouseDown()
    {
        if (buildManager.GetTowerToBuild() == null) 
            return;
        
        if (turret != null)
        {
            Debug.Log("Turret already there"); 
            return;
        }

        GameObject turretToBuild = buildManager.GetTowerToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + offset, transform.rotation);

    }

    void OnMouseEnter()
    {
        if(buildManager.GetTowerToBuild() == null) 
            return;
        GetComponent<Renderer>().material.color = hoverColer;
    }

    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = startColor;
    }
}
