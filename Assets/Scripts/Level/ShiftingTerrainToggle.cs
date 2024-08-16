using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShiftingTerrainToggle : MonoBehaviour
{
    private GameObject TerrainObject;
    private GameObject BarrierObject;
    public bool InitialTerrainActive;

    // Start is called before the first frame update
    void Start()
    {
        TerrainObject = this.gameObject.transform.Find("Terrain").gameObject;
        BarrierObject = this.gameObject.transform.Find("Barrier").gameObject;
    }
    private void Update()
    {
        ToggleTerrainState();
    }

    void ToggleTerrainState()
    {
        if (TerrainObject != null && BarrierObject != null)
        {
            if (InitialTerrainActive)
            {
                TerrainObject.SetActive(true);
                BarrierObject.SetActive(false);
            }
            else
            {
                TerrainObject.SetActive(false);
                BarrierObject.SetActive(true);
            }
        }
    }
}
