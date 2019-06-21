using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject Enemy_Tutorial;
    public GameObject Enemy_English;
    public GameObject Enemy_Math;

    private void Start()
    {
        switch (Counter.counter)
        {
            case 0: Vanish(); Enemy_Tutorial.SetActive(true); break;
            case 1: Vanish(); Enemy_English.SetActive(true); break;
            case 2: Vanish(); Enemy_Math.SetActive(true); break;
        }
    }
    private void Vanish()
    {
        Enemy_Tutorial.SetActive(false);
        Enemy_English.SetActive(false);
        Enemy_Math.SetActive(false);
    }
}
