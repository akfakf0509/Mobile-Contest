using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PanelButton : Blink
{
    public GameObject Window;

    private bool isOpen = true;
    //void Start()
    //{
    //PauseWindow.SetActive(true);
    //StartCoroutine(WaitFor(2f));
    //Invoke("appear", 2);
    //PauseWindow.SetActive(false);

    //Debug.Log(Counter.Stage_count);
    //}

    //IEnumerator WaitFor(float time)
    //{
    //    yield return new WaitForSeconds(time);
    //}

    public void OpenClick()
    {
        if (isOpen)
        {
            Window.SetActive(false);
            isOpen = false;
            Time.timeScale = 1;
        }
        else
        {
            Window.SetActive(true);
            isOpen = true;
            Time.timeScale = 0;
        }
        
    }

    public void CloseClick()
    {
        Window.SetActive(false);
        isOpen = false;
        Time.timeScale = 1;
    }

    public void HomeClick()
    {
        Time.timeScale = 0;
        SceneManager.LoadScene("StageScene");
    }
}
