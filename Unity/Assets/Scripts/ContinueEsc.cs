using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ContinueEsc : MonoBehaviour
{
    public bool escapeMenuActive;
    public GameObject UI;
    public GameObject MenuContinue;
    public GameObject Help;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (escapeMenuActive == false)
            {
                escapeMenuActive = true;
                UI.gameObject.SetActive(false);
                Help.gameObject.SetActive(false);
                MenuContinue.gameObject.SetActive(true);
            }
            else
            {
                escapeMenuActive = false;
                MenuContinue.gameObject.SetActive(false);
                UI.gameObject.SetActive(true);
                Help.gameObject.SetActive(false);
            }
        }
    }
    public void ContinuePressed()
    {
        escapeMenuActive = false;
        MenuContinue.gameObject.SetActive(false);
        UI.gameObject.SetActive(true);
    }
    public void ExitPressed()
    {
        Application.Quit();
    }
}
