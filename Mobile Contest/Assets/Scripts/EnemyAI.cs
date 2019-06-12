using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public GameObject basic_skill;
    Animator animator;
    private Vector3 target = new Vector3(0, 0, 0);

    private short mode = 0;
    public float speed = 70f;
    private bool basic_skill_cooltime = false;

    void Awake()
    {
        animator = transform.GetChild(0).gameObject.GetComponent<Animator>();    
    }

    void Update()
    {
        if(Mathf.Round(transform.position.x) == target.x)
        {
            mode = 0;
            animator.SetBool("is_walk", false);
            target = new Vector3(Random.Range(-83, 84), 0, 0);

            StartCoroutine("Wait_for");
        }
        else if(mode == 1)
        {
            Ai_movement();
        }
        if (transform.Find("HealthBar").GetComponent<HealthManager>().health <= 0)
        {
            //죽으면
        }
        //이동

        if (!basic_skill_cooltime)  
        {
            GameObject skill = Instantiate(basic_skill);
            GameObject player = GameObject.Find("Player_object/Player");
            skill.transform.position = transform.Find("Enemy_Arrow/Arrow_position").transform.position;
            skill.transform.rotation = Quaternion.Euler(0, 0, Mathf.Atan2(player.transform.position.y - skill.transform.position.y, player.transform.position.x - skill.transform.position.x) * 180f / Mathf.PI);
            skill.transform.Rotate(new Vector3(0, 0, -90 + Random.Range(-20, 20)));
            mode = 0;
            basic_skill_cooltime = true;
            StartCoroutine("Skill_delay");
            StartCoroutine("Skill_cooltime");
        }
    }

    void Ai_movement()
    {
        if (target.x > transform.position.x)
        {
            animator.SetBool("is_walk", true);
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            transform.GetChild(0).transform.localScale = new Vector2(-1.5f, 1.5f);
        }

        else
        {
            animator.SetBool("is_walk", true);
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            transform.GetChild(0).transform.localScale = new Vector2(1.5f, 1.5f);
        }
          
    }

    IEnumerator Wait_for()
    {
        yield return new WaitForSeconds(Random.Range(0f, 3f));
        mode = 1;
    }
    IEnumerator Skill_delay()
    {
        yield return new WaitForSeconds(0.1f);
        mode = 1;
    }
    IEnumerator Skill_cooltime()
    {
        yield return new WaitForSeconds(Random.Range(2f, 2f));
        basic_skill_cooltime = false;
    }
}