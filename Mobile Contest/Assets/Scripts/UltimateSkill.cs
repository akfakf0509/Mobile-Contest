using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UltimateSkill : MonoBehaviour
{
    public GameObject basic_skill;
    private float scale = 2f;

    void Update()
    {
        transform.localScale = new Vector2(scale, scale);
        scale += 1f * Time.deltaTime;
        if (scale >= 6)
            Explode();
    }
    void Explode()
    {
        for(int a=0; a<3; a++)
            Instantiate(basic_skill, transform.position, Quaternion.Euler(0,0,-20 + 20 * a));
        Destroy(gameObject);
    }
}
