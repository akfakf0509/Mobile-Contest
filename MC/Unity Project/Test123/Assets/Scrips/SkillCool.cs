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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerDown(BaseEventData data)
    {
        if (isCan)
        {
            StartCoroutine(CoolTime(this.Skill_Cool));
        }

        /*img_Skill.transform.localScale = new Vector3(1, 1, 1);
        StartCoroutine(waitfor(0.1f));
        img_Skill.transform.localScale = new Vector3(0.8f, 0.8f, 1);*/
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
