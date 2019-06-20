using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PanelButton : Blink
{
    public GameObject Window;

    private bool isOpen = true;
    
    private void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
            if (Input.GetKey(KeyCode.Escape))
                OpenClick();
    }

    public void OpenClick()
    {
        if (isOpen)
        {
            Window.SetActive(!isOpen);
            isOpen = !isOpen;
            Time.timeScale = 1;
        }
        else
        {
            Window.SetActive(!isOpen);
            isOpen = !isOpen;
            Time.timeScale = 0;
        }
    }

    public void HomeClick()
    {
        Time.timeScale = 0;
        SceneManager.LoadScene("StageScene");
    }

    public void OUTClick()
    {
        Application.Quit();
    }

    public void Stage_Clear()
    {
        switch (Stage_count)
        {
            case 1: this.isStage1 = true; break;
            case 2: this.isStage2 = true; break;
        }
    }
}
