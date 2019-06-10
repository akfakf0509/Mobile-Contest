using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicSkill : MonoBehaviour
{
    public float skill_speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * skill_speed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        coll.gameObject.transform.parent.Find("HealthBar").GetComponent<HealthManager>().health -= 10;
        Destroy(gameObject);
    }
}
