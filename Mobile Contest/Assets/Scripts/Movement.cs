using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    Animator animator;
    public float speed = 100;

    void Awake()
    {
        animator = transform.GetChild(0).gameObject.GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (!GameObject.Find("SkillManager").GetComponent<SkillManager>().doing)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                animator.SetBool("is_walk", true);
                transform.Translate(Vector2.left * speed * Time.deltaTime);
                transform.GetChild(0).transform.localScale = new Vector2(1.5f, 1.5f);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                animator.SetBool("is_walk", true);
                transform.Translate(Vector2.right * speed * Time.deltaTime);
                transform.GetChild(0).localScale = new Vector2(-1.5f, 1.5f);
            }
            else
                animator.SetBool("is_walk", false);
        }
        else
            animator.SetBool("is_walk", false);
    }
}
