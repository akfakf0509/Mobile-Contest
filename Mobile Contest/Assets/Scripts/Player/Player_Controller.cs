using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player_Controller : MonoBehaviour
{
    Animator animator;

    public float moveSpeed = 50f;

    void Awake()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        animator.SetBool("is_walk", false);

        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -58)
        {
            Player_moveLeft();
        }
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 58)
        {
            Player_moveRight();
        }

    }

    public void Player_moveLeft()
    {
        animator.SetBool("is_walk", true);
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        transform.localScale = new Vector3(1.7f, 1.7f, 1f);
    }

    public void Player_moveRight()
    {
        animator.SetBool("is_walk", true);
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        transform.localScale = new Vector3(-1.7f, 1.7f, 1f);
    }
}
