﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuto_Basic : MonoBehaviour
{
    public float speed = 70f;

    private float damage;

    void Awake()
    {
        Destroy(gameObject, 3f);
        damage = GameObject.Find("SkillManager").GetComponent<SkillManager>().player_basic_damge;
    }

    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            GameObject.Find("HealthBarManager").GetComponent<HearthBarManager>().Do_minus(damage);
            Destroy(gameObject);
        }
    }

    public void Set_damage(float dam)
    {
        damage = dam;
    }
}
