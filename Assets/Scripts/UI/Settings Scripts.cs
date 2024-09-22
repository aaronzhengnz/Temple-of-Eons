using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsScripts : MonoBehaviour
{
    public GameObject SettingsPage;

    void Start()
    {
        // Hide the SettingsPage when the game starts in play mode
        if (!Application.isPlaying && SettingsPage != null)
        {
            SettingsPage.SetActive(false);
        }
    }

    void Update()
    {
        // In play mode, check for Escape key input
        if (Application.isPlaying && Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleSettings();
        }
    }

    public void ToggleSettings()
    {
        if (SettingsPage != null)
        {
            SettingsPage.SetActive(!SettingsPage.activeSelf);
            Debug.Log("Settings Page active: " + SettingsPage.activeSelf);
        }
        else
        {
            Debug.LogWarning("SettingsPage is not assigned in the Inspector!");
        }
    }

    public void ExitLevel()
    {
        SceneManager.LoadScene("Level Select Scene");
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Stop play mode in the Editor
#else
        Application.Quit(); // Quit the application
#endif
    }
}
