using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ExitScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider Character)
    {
        if (Character.CompareTag("Player"))
        {
            SceneManager.LoadScene("Level 1 - Complete");
        }
    }
}
