using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public static int counter;

    public static bool[] isStage = new bool[3] { true, false, false };

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    private void Update()
    {
        counter = StageManager.Stage_count;
    }
}
