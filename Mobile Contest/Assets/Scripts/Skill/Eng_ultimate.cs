using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eng_ultimate : MonoBehaviour
{
    public Vector2 target;

    public float arrive_time = 2f;
    private float damage;

    void Awake()
    {
        damage = GameObject.Find("SkillManager").GetComponent<SkillManager>().player_ultimate_damge * 2;
        target = new Vector2(Random.Range(-75f, 75f), -70);
    }

    void Update()
    {
        float to_move_x = target.x - transform.position.x;
        float to_move_y = target.y - transform.position.y;
        if (-2 <= to_move_x && to_move_x <= 2 && -2 <= to_move_y && to_move_y <= 2)
        {
            Destroy(gameObject);
        }
        transform.Translate(new Vector3(to_move_x / arrive_time * Time.deltaTime, to_move_y / arrive_time * Time.deltaTime));
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
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
                coll.gameObject.GetComponent<Skill_Shield>().Event();
                Destroy(gameObject);
            }
            catch { }
        }
    }
}
