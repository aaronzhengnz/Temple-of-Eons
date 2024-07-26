using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeWarp : MonoBehaviour
{

    public GameObject PastTimeWarp;
    public GameObject PresentTimeWarp;
    public GameObject FutureTimeWarp;

    private void OnTriggerStay(Collider Character)
    {
        if (Character.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.Alpha1))
            {
                Character.transform.position = PastTimeWarp.transform.Find("Teleport Point").transform.position;
            }
            if (Input.GetKey(KeyCode.Alpha2))
            {
                Character.transform.position = PresentTimeWarp.transform.Find("Teleport Point").transform.position;
            }
            if (Input.GetKey(KeyCode.Alpha3))
            {
                Character.transform.position = FutureTimeWarp.transform.Find("Teleport Point").transform.position;
            }
        }
    }
}
