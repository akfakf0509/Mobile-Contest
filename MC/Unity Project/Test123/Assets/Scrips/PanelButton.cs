using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PanelButton : Counter
{
    public Button btn;
    public GameObject PauseWindow;

    private bool isOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        //PauseWindow.SetActive(true);
        //StartCoroutine(WaitFor(2f));
        //Invoke("appear", 2);
        //PauseWindow.SetActive(false);

        //Debug.Log(Counter.Stage_count);
    }

    IEnumerator WaitFor(float time)
    {
        yield return new WaitForSeconds(time);
    }

    public void OnPointerDown()
    {
        btn.transform.localScale = new Vector3(1.2f, 1.2f, 1);
    }

    public void OnPointerUp()
    {
        btn.transform.localScale = new Vector3(1, 1, 1);
    }

    public void OpenClick()
    {
        Debug.Log(";lkj");
        if (isOpen)
        {
            PauseWindow.SetActive(false);
            isOpen = false;
        }
        else
        {
            PauseWindow.SetActive(true);
            isOpen = true;
        }
        
        Time.timeScale = 0;
    }

    public void CloseClick()
    {
        PauseWindow.SetActive(false);
        isOpen = false;
        Debug.Log("asdf");
        Time.timeScale = 1;
    }

    public void HomeClick()
    {
        Time.timeScale = 0;
        SceneManager.LoadScene("StageScene");
    }
}
