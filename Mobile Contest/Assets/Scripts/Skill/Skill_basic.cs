using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_basic : MonoBehaviour
{
    public float speed = 30f;

    private float damage;

    void Awake()
    {
        Destroy(gameObject, 3f);
        damage = GameObject.Find("SkillManager").GetComponent<SkillManager>().player_basic_damge;
    }

    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    void OnTriggerStay2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Enemy")
        {
            GameObject.Find("HealthBarManager").GetComponent<HearthBarManager>().Do_add(damage);
            Destroy(gameObject);
        }
        if(coll.gameObject.tag == "EventSkill")
        {
            coll.GetComponent<Skill_ultimate>().Event();
            Destroy(gameObject);
        }
    }

    public void Set_damage(float dam)
    {
        damage = dam;
    }
}
