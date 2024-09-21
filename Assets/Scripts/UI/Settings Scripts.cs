using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsScripts : MonoBehaviour
{

    public GameObject SettingsPage;

    // Start is called before the first frame update
    void Start()
    {
        SettingsPage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleSettings();
        }
    }

    public void ToggleSettings()
    {
        SettingsPage.SetActive(!SettingsPage.activeSelf);
    }

    public void ExitLevel()
    {
        SceneManager.LoadScene("Level Select Scene");
    }
}
