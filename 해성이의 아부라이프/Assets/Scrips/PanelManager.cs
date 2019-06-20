using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelManager : MonoBehaviour
{
    public GameObject Window;

    public void OpenClick()
    {
        Window.SetActive(true);
    }

    public void CloseClick()
    {
        Window.SetActive(false);
    }

    public void QuitClick()
    {
        Application.Quit();
    }

    public void HomeClick()
    {
        SceneManager.LoadScene("StageScene");
    }
}
