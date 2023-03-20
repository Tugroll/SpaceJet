using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameMenu : MonoBehaviour
{

    [SerializeField] Button menuButton;
    
    public void Toggle()
    {
        bool val = !gameObject.activeSelf;
        if (val)
        {
            Time.timeScale = 0;
            gameObject.SetActive(true);
            menuButton.interactable = false;
        }
        else
        {
            Time.timeScale = 1;
            gameObject.SetActive(false);
        }
    }
    private void OnDestroy()
    {
        Time.timeScale = 1;
    }
}
