using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScript : MonoBehaviour
{
    public GameObject NewTuto;
    public GameObject TutoTexts;

    private void OnTriggerEnter(Collider Character)
    {
        if (Character.CompareTag("Player"))
        {
            int childCount = TutoTexts.transform.childCount;

            for (int i = 0; i < childCount; i++)
            {
                // Access each child by index and set it inactive
                TutoTexts.transform.GetChild(i).gameObject.SetActive(false);
            }

            NewTuto.SetActive(true);
        }
    }
}
