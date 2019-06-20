using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_ArrowMovement : MonoBehaviour
{
    GameObject arrow_standard;

    public float angle = 0;
    public bool rotate_left = true;

    void Awake()
    {
        arrow_standard = transform.parent.Find("Arrow_standard").gameObject;
    }

    void Update()
    {
        if(angle > 50)
        {
            rotate_left = false;
        }
        else if(angle < -50)
        {
            rotate_left = true;
        }

        if (rotate_left)
        {
            angle += 80f * Time.deltaTime;
            transform.RotateAround(arrow_standard.transform.position, Vector3.forward, 80f * Time.deltaTime);
        }
        else if (!rotate_left)
        {
            angle -= 80f * Time.deltaTime;
            transform.RotateAround(arrow_standard.transform.position, Vector3.back, 80f * Time.deltaTime);
        }
    }
}
