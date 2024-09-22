using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[ExecuteInEditMode]
public class SettingsScripts : MonoBehaviour
{
    public GameObject SettingsPage;

    // This will run in both edit mode and play mode
    void Update()
    {
        // In the Editor, make sure the SettingsPage is hidden
        if (!Application.isPlaying)
        {
            if (SettingsPage != null)
                SettingsPage.SetActive(false);
        }

        // In play mode, check for Escape key input
        if (Application.isPlaying && Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleSettings();
        }
    }

    public void ToggleSettings()
    {
        if (SettingsPage != null)
            SettingsPage.SetActive(!SettingsPage.activeSelf);
    }

    public void ExitLevel()
    {
        SceneManager.LoadScene("Level Select Scene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
