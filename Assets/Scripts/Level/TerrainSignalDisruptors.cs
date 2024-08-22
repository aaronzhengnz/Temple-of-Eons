using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainSignalDisruptors : MonoBehaviour
{
    public GameObject CurrentMap;
    public GameObject PastMap;
    public GameObject PresentMap;
    public GameObject FutureMap;

    private void OnTriggerStay(Collider Character)
    {
        if (Character.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (CurrentMap.name == PastMap.transform.parent.transform.parent.name)
                {
                    ToggleTerrain(PastMap.transform);
                }
                else if (CurrentMap.name == PresentMap.transform.parent.transform.parent.name)
                {
                    ToggleTerrain(PresentMap.transform);
                    ToggleTerrain(PastMap.transform);
                }
                else if (CurrentMap.name == FutureMap.transform.parent.transform.parent.name)
                {
                    ToggleTerrain(FutureMap.transform);
                    ToggleTerrain(PresentMap.transform);
                    ToggleTerrain(PastMap.transform);
                }
            }
        }
    }

    void ToggleTerrain(Transform map)
    {
        Transform shiftingTerrainObject = map.Find("Shifting Terrain");
        for (int i = 0; i < shiftingTerrainObject.childCount; i++)
        {
            Transform terrainObject = shiftingTerrainObject.GetChild(i).transform.Find("Terrain");
            Transform barrierObject = shiftingTerrainObject.GetChild(i).transform.Find("Barrier");
            if (terrainObject != null)
            {
                bool isActive = terrainObject.gameObject.activeSelf;
                Debug.Log(terrainObject.gameObject.activeSelf);
                if (isActive)
                {
                    terrainObject.gameObject.SetActive(false);
                    barrierObject.gameObject.SetActive(true);
                }
                else if (isActive == false)
                {
                    terrainObject.gameObject.SetActive(true);
                    barrierObject.gameObject.SetActive(false);
                }
            }
        }
    }
}
