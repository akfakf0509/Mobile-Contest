using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    public GameObject Stage1;
    public GameObject Stage2;
    public GameObject Stage3;
    public GameObject Stage4;
    public GameObject Stage5;

    static int count;

    void Start()
    {
        count = 1;
    }


    void FixedUpdate()
    {
        switch (count)
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
        if (count < 5)
            count++;
    }

    public void onClick_pre()
    {
        if (count > 1)
            count--;
    }

 //   public void stage_Selected()
 //   {

 //   }
}
