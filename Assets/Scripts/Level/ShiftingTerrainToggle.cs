using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShiftingTerrainToggle : MonoBehaviour
{

    private GameObject Terrain;
    private GameObject Barrier;
    public bool InitialTerrainActive;

    // Start is called before the first frame update
    void Start()
    {
        Terrain = GameObject.Find("Terrain");
        Barrier = GameObject.Find("Barrier");

        if (Terrain == null)
        {
            Debug.LogError("Terrain GameObject not found");
        }

        if (Barrier == null)
        {
            Debug.LogError("Barrier GameObject not found");
        }

        // Set initial state based on InitialTerrainActive
        ToggleTerrainState();
    }

    void ToggleTerrainState()
    {
        if (Terrain != null && Barrier != null)
        {
            if (InitialTerrainActive)
            {
                Debug.Log("Setting Terrain active and Barrier inactive");
                Terrain.SetActive(true);
                Barrier.SetActive(false);
            }
            else
            {
                Debug.Log("Setting Terrain inactive and Barrier active");
                Terrain.SetActive(false);
                Barrier.SetActive(true);
            }
        }
    }

    private void Update()
    {
        ToggleTerrainState();
    }
}
