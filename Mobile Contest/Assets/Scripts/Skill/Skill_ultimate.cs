using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_ultimate : MonoBehaviour
{
    public float damage;

    public float size = 2.5f;

    void Awake()
    {
        Destroy(gameObject, 5f);
        damage = GameObject.Find("SkillManager").GetComponent<SkillManager>().player_ultimate_damge;
    }

    void Update()
    {
        if (size < 4.5f)
        {
            size += 1 * Time.deltaTime;
            transform.localScale = new Vector3(size, size);
        }
    }

    public void Event(Quaternion quaternion)
    {
        Destroy(gameObject);

        GameObject arrow;
        GameObject skillmanager;
        arrow = GameObject.Find("Arrow_img");
        skillmanager = GameObject.Find("SkillManager");

        if (size < 3.5f)
        {
            skillmanager.GetComponent<SkillManager>().Use_player_basic(arrow.transform.position, quaternion, false);
        }
        else if (size < 4.5f)
        {
            skillmanager.GetComponent<SkillManager>().Use_player_basic(arrow.transform.position, Quaternion.Euler(0, 0, quaternion.z * 100), false);
            skillmanager.GetComponent<SkillManager>().Use_player_basic(arrow.transform.position, Quaternion.Euler(0, 0, quaternion.z * 100 + 10), false);
            skillmanager.GetComponent<SkillManager>().Use_player_basic(arrow.transform.position, Quaternion.Euler(0, 0, quaternion.z * 100 - 10), false);
        }
        else
        {
            skillmanager.GetComponent<SkillManager>().Use_player_basic(arrow.transform.position, Quaternion.Euler(0, 0, quaternion.z * 100), false);
            skillmanager.GetComponent<SkillManager>().Use_player_basic(arrow.transform.position, Quaternion.Euler(0, 0, quaternion.z * 100 + 10), false);
            skillmanager.GetComponent<SkillManager>().Use_player_basic(arrow.transform.position, Quaternion.Euler(0, 0, quaternion.z * 100 - 10), false);
            skillmanager.GetComponent<SkillManager>().Use_player_basic(arrow.transform.position, Quaternion.Euler(0, 0, quaternion.z * 100 + 20), false);
            skillmanager.GetComponent<SkillManager>().Use_player_basic(arrow.transform.position, Quaternion.Euler(0, 0, quaternion.z * 100 - 20), false);
        }
    }

    public void Set_damage(float dam)
    {
        damage = dam;
    }
}
