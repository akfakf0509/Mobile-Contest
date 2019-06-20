using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_tuto_AI : MonoBehaviour
{
    Animator animator;

    public float moveSpeed = 50f;

    void Awake()
    {
        Idle();
    }

    void Update()
    {

    }

    private void Idle()
    {
        float idle_time = Random.Range(0f, 3f);
        while (idle_time > 0)
        {
            idle_time -= Time.deltaTime;
        }
        Move();
    }

    private void Move()
    {
        Vector3 target = new Vector3(Random.Range(-60f, 60f), 30);

        while (Mathf.Abs(target.x) != Mathf.Abs(transform.position.x))
        {
            if(Mathf.Abs(target.x) < Mathf.Abs(transform.position.x))
            {
                MoveLeft();
            }
            if(Mathf.Abs(target.x) < Mathf.Abs(transform.position.x))
            {
                MoveRight();
            }
        }
        Idle();
    }

    private void MoveLeft()
    {
        animator.SetBool("is_walk", true);
        transform.parent.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        transform.localScale = new Vector3(2f, 2f, 1f);
    }

    private void MoveRight()
    {
        animator.SetBool("is_walk", true);
        transform.parent.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        transform.localScale = new Vector3(-2f, 2f, 1f);
    }

    private void Use_basic()
    {

    }
}
