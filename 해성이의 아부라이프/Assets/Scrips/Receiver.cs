using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Receiver : MonoBehaviour
{
    public Text text;
    int receive;

    void Start()
    {
        receive = Counter.counter;
        text.text = "" + receive;
    }

    void Update()
    {
        
    }
}
