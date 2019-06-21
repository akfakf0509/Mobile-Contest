using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_basic : MonoBehaviour
{
    public float speed = 70f;

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

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Enemy")
        {
            GameObject.Find("HealthBarManager").GetComponent<HearthBarManager>().Do_add(damage);
            Destroy(gameObject);
        }
        if(coll.gameObject.tag == "Player")
        {
            GameObject.Find("HealthBarManager").GetComponent<HearthBarManager>().Do_minus(damage);
            Destroy(gameObject);
        }
    }
    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "EventSkill")
        {
            try
            {
                coll.GetComponent<Skill_ultimate>().Event(transform.rotation);
                Destroy(gameObject);
            }
            catch { }
            
        }
    }

    public void Set_damage(float dam)
    {
        damage = dam;
    }
}
