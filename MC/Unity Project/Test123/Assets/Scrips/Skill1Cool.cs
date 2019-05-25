using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skill1Cool : MonoBehaviour
{
    public Image img_Skill;
    public Text Skill1Txt;

    private bool isCan = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown && isCan)
        {
            StartCoroutine(CoolTime (3f));
        }
    }

    IEnumerator CoolTime(float cool)
    {
        float realcool = cool;
        isCan = false;
        while (cool >= 0.0f)
        {
            cool -= Time.deltaTime;
            img_Skill.fillAmount = (realcool-cool)/3;
            Skill1Txt.text = "" + Mathf.Round(cool*10)/10;
            yield return new WaitForFixedUpdate();
        }
        Skill1Txt.text = "";
        isCan = true;
    }
}
