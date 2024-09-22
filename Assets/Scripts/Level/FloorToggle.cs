using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class FloorToggle : MonoBehaviour
{

    public GameObject Floor;
    public GameObject TimeUI;

    private void Start()
    {
        Floor.SetActive(false);
    }

    private void OnTriggerEnter(Collider Character)
    {
        if (Character.CompareTag("Player"))
        {
            Floor.SetActive(true);
        }
    }
    private void OnTriggerStay(Collider Character)
    {
        if (Character.CompareTag("Player")) {
            Floor.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider Character)
    {
        if (Character.CompareTag("Player"))
        {
            Floor.SetActive(false);
        }
    }
}
