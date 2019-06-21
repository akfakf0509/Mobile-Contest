using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBlink : MonoBehaviour
{
    public Text txt;
    bool isHide = true;
    float hideSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Color color = txt.color;
        if (isHide)
        {
            color.a = color.a - Time.deltaTime * hideSpeed;
            if (color.a < 0)
            {
                isHide = false;
                color.a = 0.0f;
            }
            txt.color = color;
        }
        else
        {
            color.a = color.a + Time.deltaTime * hideSpeed;
            if (color.a > 1)
            {
                isHide = true;
                color.a = 1.0f;
            }
            txt.color = color;
        }
    }

    public IEnumerator BlinkText()
    {
        while (true)
        {
            txt.text = "";
            yield return new WaitForSeconds(0.5f);
            txt.text = "Touch to start";
            yield return new WaitForSeconds(0.5f);
        }
    }
}
