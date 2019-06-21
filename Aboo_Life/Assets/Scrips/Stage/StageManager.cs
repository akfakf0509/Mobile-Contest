using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageManager : PanelManager
{
    public GameObject Tutorial;
    public GameObject Stage1;
    public GameObject Stage2;
    public GameObject Stage3;

    public static int Stage_count;

    private void Start()
    {
        Stage_count = Counter.counter;
        Vanish();
    }

    private void Update()
    {
        switch (Stage_count)
        {
            case 0:
                Vanish(); Tutorial.SetActive(true); break;
            case 1:
                Vanish(); Stage1.SetActive(true); break;
            case 2:
                Vanish(); Stage2.SetActive(true); break;
            case 3:
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
        if (Stage_count < 3)
            Stage_count++;
    }

    public void onClick_pre()
    {
        if (Stage_count > 0)
            Stage_count--;
    }

    public void stage_Selected()
    {

        if (Stage_count == 0 && Counter.isStage[Stage_count])
            SceneManager.LoadScene("GameScene");

        else if (Stage_count == 1 && Counter.isStage[Stage_count])
            SceneManager.LoadScene("GameScene");

        else if (Stage_count == 2 && Counter.isStage[Stage_count])
            SceneManager.LoadScene("GameScene");

    }
}
