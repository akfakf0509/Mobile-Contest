using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PanelButton : Blink
{
    public GameObject PauseWindow;

    private bool isOpen = true;
    //void Start()
    //{
    //PauseWindow.SetActive(true);
    //StartCoroutine(WaitFor(2f));
    //Invoke("appear", 2);
    //PauseWindow.SetActive(false);

    //Debug.Log(Counter.Stage_count);
    //}

    IEnumerator WaitFor(float time)
    {
        yield return new WaitForSeconds(time);
    }

    public void OpenClick()
    {
        //Debug.Log(";lkj");
        if (isOpen)
        {
            PauseWindow.SetActive(false);
            isOpen = false;
            Time.timeScale = 1;
        }
        else
        {
            PauseWindow.SetActive(true);
            isOpen = true;
            Time.timeScale = 0.1f;
        }
        
    }

    public void CloseClick()
    {
        PauseWindow.SetActive(false);
        isOpen = false;
        Time.timeScale = 1;
    }

    public void HomeClick()
    {
        Time.timeScale = 0;
        SceneManager.LoadScene("StageScene");
    }
}
