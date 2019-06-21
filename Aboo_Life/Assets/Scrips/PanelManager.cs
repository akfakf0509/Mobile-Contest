using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelManager : MonoBehaviour
{
    public GameObject Window;

    private void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                OpenClick();
            }
    }

    public void OpenClick()
    {
        Window.SetActive(true);
        Time.timeScale = 0;
    }

    public void CloseClick()
    {
        Window.SetActive(false);
        Time.timeScale = 1;
    }

    public void QuitClick()
    {
        Application.Quit();
    }

    public void ClearThisStage()
    {
        Counter.isStage[Counter.counter + 1] = true;
    }

    public void HomeClick()
    {
        SceneManager.LoadScene("StageScene");
    }
}
