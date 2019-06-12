using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageManager : Counter
{
    public GameObject Stage1;
    public GameObject Stage2;
    public GameObject Stage3;
    public GameObject Stage4;
    public GameObject Stage5;

    void Start()
    {
        Counter.Stage_count = 1;
    }


    void FixedUpdate()
    {
        switch (Counter.Stage_count)
        {
            case 1:
                Vanish(); Stage1.SetActive(true); break;
            case 2:
                Vanish(); Stage2.SetActive(true); break;
            case 3:
                Vanish(); Stage3.SetActive(true); break;
            case 4:
                Vanish(); Stage4.SetActive(true); break;
            case 5:
                Vanish(); Stage5.SetActive(true); break;
        }
    }

    void Vanish()
    {
        Stage1.SetActive(false);
        Stage2.SetActive(false);
        Stage3.SetActive(false);
        Stage4.SetActive(false);
        Stage5.SetActive(false);
    }

    public void onClick_next()
    {
        if (Counter.Stage_count < 5)
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
