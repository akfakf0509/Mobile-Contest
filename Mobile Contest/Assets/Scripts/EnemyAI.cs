using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    Animator animator;
    private Vector3 target = new Vector3(0, 0, 0);

    private short mode = 0;
    private float speed = 70f;

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
        yield return new WaitForSeconds(Random.Range(0f, 2f));
        mode = 1;
    }
}