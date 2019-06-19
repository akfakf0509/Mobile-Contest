using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_basic : MonoBehaviour
{
    public float speed = 30f;

    void Awake()
    {
        Destroy(gameObject, 3f);
    }

    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Enemy")
        {
            GameObject.Find("HealthBarMangaer").GetComponent<HearthBarManager>().Do_add(GameObject.Find("SkillManager").GetComponent<SkillManager>().player_basic_damge);
        }
    }
}
