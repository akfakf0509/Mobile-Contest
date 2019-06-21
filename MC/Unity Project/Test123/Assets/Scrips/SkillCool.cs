using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SkillCool : MonoBehaviour
{
    public GameObject player;
    public Image img_Skill;
    public Text SkillTxt;
    public float Skill_Cool;

    private bool isCan = true;

    public void OnPointerDown(BaseEventData data)
    {
        img_Skill.transform.localScale = new Vector3(1, 1, 1);
        /*img_Skill.transform.localScale = new Vector3(1, 1, 1);
        StartCoroutine(waitfor(0.1f));
        img_Skill.transform.localScale = new Vector3(0.8f, 0.8f, 1);*/
    }

    public void OnPointerUp(BaseEventData data)
    {
        img_Skill.transform.localScale = new Vector3(0.8f, 0.8f, 1);
        if (isCan && Time.timeScale == 1)
        {
            StartCoroutine(CoolTime(this.Skill_Cool));
        }
    }

    /*IEnumerator waitfor(float wait)
    {
        yield return new WaitForSeconds(wait);
    }*/

    IEnumerator CoolTime(float cool)
    {
        isCan = false;
        while (cool >= 0.0f)
        {
            cool -= Time.deltaTime;
            img_Skill.fillAmount = (this.Skill_Cool-cool)/this.Skill_Cool;
            SkillTxt.text = "" + Mathf.Round(cool*10)/10;
            yield return new WaitForFixedUpdate();
        }
        SkillTxt.text = "";
        isCan = true;
    }
}
