using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSignalDisruptor : MonoBehaviour
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
        Transform obstacleObject = map.Find("Particles");
        for (int i = 0; i < obstacleObject.childCount; i++)
        {
            Transform particleSystem = obstacleObject.GetChild(i).transform.Find("Particle System");
            Transform barrierObject = obstacleObject.GetChild(i).transform.Find("Barrier");
            if (particleSystem != null)
            {
                bool isActive = particleSystem.gameObject.activeSelf;
                if (isActive)
                {
                    particleSystem.gameObject.SetActive(false);
                    barrierObject.gameObject.SetActive(false);
                }
                else if (isActive == false)
                {
                    particleSystem.gameObject.SetActive(true);
                    barrierObject.gameObject.SetActive(true);
                }
            }
        }
    }
}
