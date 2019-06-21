using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SkillManager : MonoBehaviour
{
    public Image img_Skill;
    public Text SkillTxt;
    public float Skill_Cool;

    private bool isCan = true;

    public void SkillStart(BaseEventData data)
    {
        if (isCan && Time.timeScale == 1)
        {
            StartCoroutine(CoolTime(Skill_Cool));
        }
    }

    IEnumerator CoolTime(float cool)
    {
        isCan = false;
        while (cool >= 0.0f)
        {
            cool -= Time.deltaTime;
            img_Skill.fillAmount = (Skill_Cool - cool) / Skill_Cool;
            SkillTxt.text = "" + Mathf.Round(cool * 10) / 10;
            yield return new WaitForFixedUpdate();
        }
        SkillTxt.text = "";
        isCan = true;
    }
}
