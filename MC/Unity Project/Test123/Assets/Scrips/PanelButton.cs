using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelButton : MonoBehaviour
{
    public GameObject PauseWindow;
    // Start is called before the first frame update
    void Start()
    {
        PauseWindow.SetActive(false);
    }

    public void OpenClick()
    {
        PauseWindow.SetActive(true);
        Time.timeScale = 0;
    }

    public void CloseClick()
    {
        PauseWindow.SetActive(false);
        Time.timeScale = 1;
    }

    public void HomeClick()
    {
        SceneManager.LoadScene("StageScene");
        Time.timeScale = 0;
    }
}
