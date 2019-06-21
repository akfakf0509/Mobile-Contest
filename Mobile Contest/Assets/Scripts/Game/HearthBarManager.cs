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
        hearth -= 0.003f * Time.deltaTime;

        target.GetComponent<Image>().fillAmount = hearth;

        if (hearth <= 0)
            Game_over();
        if (hearth >= 1)
            Game_clear();
    }

    public void Do_minus(float num)
    {
        hearth -= num;
    }

    public void Do_add(float num)
    {
        hearth += num;
    }

    public void Game_clear()
    {

    }

    public void Game_over()
    {

    }
}
