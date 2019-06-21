using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_eng_AI : MonoBehaviour
{
    public GameObject skill_basic;
    public GameObject skill_ultimate;

    Animator animator;

    public enum STAT
    {
        IDLE, MOVE, SKILL_BASIC, SKILL_ULTIMATE
    };

    public STAT stat = STAT.IDLE;

    public float idle_time;
    private float idle_remain;

    public float moveSpeed = 50f;

    public Vector3 target;

    void Awake()
    {
        animator = GetComponent<Animator>();

    }

    void Start()
    {
        idle_time = Random.Range(0f, 3f);
        target = new Vector3(Random.Range(-75, 75), 30);
        idle_remain = idle_time;
        StartCoroutine(Use_basic(Random.Range(3f, 5f)));
        StartCoroutine(Use_ultimate(Random.Range(20f, 22f)));
    }

    void Update()
    {
        if (stat == STAT.IDLE)
        {
            animator.SetBool("is_walk", false);
            idle_time -= Time.deltaTime;
            if (idle_time <= 0)
            {
                stat = STAT.MOVE;
                idle_time = Random.Range(0f, 3f);
                idle_remain = idle_time;
            }
        }
        if (stat == STAT.MOVE)
        {
            if (target.x < transform.parent.position.x)
            {
                Tuto_moveLeft();
            }

            if (target.x > transform.parent.position.x)
            {
                Tuto_moveRight();
            }

            if (-2 <= target.x - transform.parent.position.x && target.x - transform.parent.position.x <= 2)
            {
                stat = STAT.IDLE;
                target = new Vector3(Random.Range(-60, 60), 30);
            }
        }
        if (stat == STAT.SKILL_BASIC)
        {
            stat = STAT.MOVE;
            GameObject skill = Instantiate(skill_basic);
            Vector3 difference = GameObject.Find("Player").transform.position - transform.position;
            float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
            skill.transform.rotation = Quaternion.Euler(0f, 0f, rotZ - 90);
            skill.transform.position = transform.parent.GetChild(1).position;
            StartCoroutine(Use_basic(Random.Range(3f, 5f)));
            //[출처] 유니티 2d 오브젝트가 마우스 바라보게 하기|작성자 강민이
        }
        if(stat == STAT.SKILL_ULTIMATE)
        {
            stat = STAT.MOVE;
            GameObject skill = Instantiate(skill_ultimate);
            skill.transform.position = new Vector2(Random.Range(-75f, 75), 70);
            StartCoroutine(Use_ultimate(Random.Range(20f, 22f)));
        }
    }

    public void Tuto_moveLeft()
    {
        animator.SetBool("is_walk", true);
        transform.parent.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        transform.localScale = new Vector3(2f, 2f, 1f);
    }

    public void Tuto_moveRight()
    {
        animator.SetBool("is_walk", true);
        transform.parent.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        transform.localScale = new Vector3(-2f, 2f, 1f);
    }

    IEnumerator Use_basic(float cooltime)
    {
        yield return new WaitForSeconds(cooltime);
        stat = STAT.SKILL_BASIC;
    }
    IEnumerator Use_ultimate(float cooltime)
    {
        yield return new WaitForSeconds(cooltime);
        stat = STAT.SKILL_ULTIMATE;
    }
}
