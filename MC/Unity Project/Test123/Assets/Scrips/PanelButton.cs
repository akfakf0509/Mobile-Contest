using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PanelButton : Counter
{
    public GameObject PauseWindow;
    public Text text1;
    // Start is called before the first frame update
    void Start()
    {
        //PauseWindow.SetActive(true);
        //StartCoroutine(WaitFor(2f));
        //Invoke("appear", 2);
        //PauseWindow.SetActive(false);

        Debug.Log(Counter.Stage_count);
    }

    IEnumerator WaitFor(float time)
    {
        yield return new WaitForSeconds(time);
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
        Time.timeScale = 0;
        SceneManager.LoadScene("StageScene");
    }
}
