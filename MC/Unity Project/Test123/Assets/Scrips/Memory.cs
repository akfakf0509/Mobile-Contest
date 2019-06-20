using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Memory : Counter
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
