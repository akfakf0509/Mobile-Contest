using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player_Controller : MonoBehaviour
{
    Animator animator;
    GameObject skillManager;
    GameObject arrow;

    public float moveSpeed = 5f;

    void Awake()
    {
        animator = gameObject.GetComponent<Animator>();
        skillManager = GameObject.Find("SkillManager");
        arrow = transform.parent.GetChild(1).GetChild(0).gameObject;
    }

    void Update()
    {
        animator.SetBool("is_walk", false);

        /*if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -75)
        {
            Player_moveLeft();
        }
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 75)
        {
            Player_moveRight();
        }*/

        if (transform.position.x > -7f && transform.position.x < 7f)
        {
            if (JoyStick.JoyVec.x < 0)
            {
                Player_moveLeft();
            }
            else if (JoyStick.JoyVec.x > 0)
            {
                Player_moveRight();
            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            skillManager.GetComponent<SkillManager>().Use_player_basic(arrow.transform.position, arrow.transform.rotation, true);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            skillManager.GetComponent<SkillManager>().Use_player_shield(new Vector3(transform.parent.position.x, -18), Quaternion.Euler(0, 0, 0), true);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            skillManager.GetComponent<SkillManager>().Use_player_ultimate(arrow.transform.position, arrow.transform.rotation, true);
        }
    }

    public void Player_moveLeft()
    {
        animator.SetBool("is_walk", true);
        /*transform.parent.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        transform.localScale = new Vector3(2f, 2f, 1f);*/
        Vector3 moveVelocity = new Vector3();
        moveVelocity = new Vector3(-1, 1, 1);
        transform.position += moveVelocity * moveSpeed * Time.deltaTime;
    }

    public void Player_moveRight()
    {
        animator.SetBool("is_walk", true);
        /*transform.parent.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        transform.localScale = new Vector3(-2f, 2f, 1f);*/
        Vector3 moveVelocity = new Vector3();
        moveVelocity = new Vector3(1, 1, 1);
        transform.position += moveVelocity * moveSpeed * Time.deltaTime;
    }
}
