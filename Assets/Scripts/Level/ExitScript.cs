using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ExitScript : MonoBehaviour
{
    // Public variable to allow setting the scene name in the Inspector
    public string sceneToLoad;

    private void OnTriggerEnter(Collider Character)
    {
        if (Character.CompareTag("Player"))
        {
            // Check if a scene name is assigned, otherwise print an error
            if (!string.IsNullOrEmpty(sceneToLoad))
            {
                SceneManager.LoadScene(sceneToLoad);
            }
            else
            {
                Debug.LogError("Scene name is not assigned!");
            }
        }
    }
}
