using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainSignalDisruptors : MonoBehaviour
{
    public GameObject CurrentMap;
    public GameObject PastMap;
    public GameObject PresentMap;
    public GameObject FutureMap;
    public string targetName;

    private void OnTriggerStay(Collider Character)
    {
        if (Character.CompareTag("Player"))
        {
            Debug.Log("Entered");
            if (Input.GetKey(KeyCode.E))
            {
                Debug.Log("E Pressed");
                if (CurrentMap == PastMap)
                {
                    ToggleAllChildren(PastMap.transform, targetName);
                }
                else if (CurrentMap == PresentMap)
                {
                    ToggleAllChildren(PresentMap.transform, targetName);
                    ToggleAllChildren(PastMap.transform, targetName);
                }
                else if (CurrentMap == FutureMap)
                {
                    ToggleAllChildren(FutureMap.transform, targetName);
                    ToggleAllChildren(PresentMap.transform, targetName);
                    ToggleAllChildren(PastMap.transform, targetName);
                }
            }
        }
    }

    void ToggleAllChildren(Transform mapParent, string targetParentName)
    {
        Transform targetParent = mapParent.Find(targetParentName);
        if (targetParent != null)
        {
            foreach (Transform child in targetParent)
            {
                child.gameObject.SetActive(!child.gameObject.activeSelf);
            }
        }
        else
        {
            Debug.LogWarning($"Target parent '{targetParentName}' not found in {mapParent.name}.");
        }
    }
}
