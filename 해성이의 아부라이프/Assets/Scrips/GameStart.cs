using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameStart : MonoBehaviour
{
    public Text txt1;
    public Text txt2;
    bool isHide = true;
    float hideSpeed = 2.0f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.touchCount > 1)
            SceneManager.LoadScene("StageScene");
        Color color = txt1.color;
        if (isHide)
        {
            color.a = color.a - Time.deltaTime * hideSpeed;
            if (color.a < 0)
            {
                isHide = false;
                color.a = 0.0f;
            }
            txt1.color = color;
            txt2.color = color;
        }
        else
        {
            color.a = color.a + Time.deltaTime * hideSpeed;
            if (color.a > 1)
            {
                isHide = true;
                color.a = 1.0f;
            }
            txt1.color = color;
            txt2.color = color;
        }
    }

    public IEnumerator BlinkText()
    {
        while (true)
        {
            txt1.text = "";
            txt2.text = "";
            yield return new WaitForSeconds(0.5f);
            txt1.text = "Touch to start";
            txt2.text = "(두 손가락 이상 눌러주세요!)";
            yield return new WaitForSeconds(0.5f);
        }
    }
}