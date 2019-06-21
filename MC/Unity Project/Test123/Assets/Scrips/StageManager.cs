using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StageManager : Counter
{
    public GameObject Tutorial;
    public GameObject Stage1;
    public GameObject Stage2;
    public GameObject Stage3;

    void Start()
    {
        Counter.Stage_count = 1;
        Vanish();
    }

    void Update()
    {
        switch (Counter.Stage_count)
        {
            case 1:
                Vanish(); Tutorial.SetActive(Tutorial); break;
            case 2:
                Vanish(); Stage1.SetActive(true); break;
            case 3:
                Vanish(); Stage2.SetActive(true); break;
            case 4:
                Vanish(); Stage3.SetActive(true); break;
        }
    }

    private void Vanish()
    {
        Tutorial.SetActive(false);
        Stage1.SetActive(false);
        Stage2.SetActive(false);
        Stage3.SetActive(false);
    }

    public void onClick_next()
    {
        if (Counter.Stage_count < 4)
            Counter.Stage_count++;
    }

    public void onClick_pre()
    {
        if (Counter.Stage_count > 1)
            Counter.Stage_count--;
    }

    public void stage_Selected()
    {
        SceneManager.LoadScene("GameScene");
    }
}
