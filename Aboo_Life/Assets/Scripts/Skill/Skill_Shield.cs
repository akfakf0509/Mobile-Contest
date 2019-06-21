using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_Shield : MonoBehaviour
{
    void Awake()
    {
        Destroy(gameObject, 3f);
    }

    public void Event()
    {
        Destroy(gameObject);
    }
}
