using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CharacterController ch;
        Vector2 xyz = new Vector2();

        if (Input.GetKey(KeyCode.A))
            ch.Move(xyz);
    }
}
