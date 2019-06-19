using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HearthBarManager : MonoBehaviour
{
    public Image target;

    public float hearth = 0.5f;

    void Update()
    {
        hearth -= 0.01f * Time.deltaTime;

        target.GetComponent<Image>().fillAmount = hearth;
    }

    public void Do_minus(float num)
    {
        hearth -= num;
    }

    public void Do_add(float num)
    {
        Debug.Log("call");
        hearth += num;
    }
}
