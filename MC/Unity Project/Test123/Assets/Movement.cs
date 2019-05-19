using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        Vector3 moveVelocity = new Vector3();
        if (Input.GetAxisRaw("Horizontal") > 0)
            moveVelocity = transform.right;
        else if (Input.GetAxisRaw("Horizontal") < 0)
            moveVelocity = new Vector3(-1, 0, 0);

        transform.position += moveVelocity * speed * Time.deltaTime;
    }
}
