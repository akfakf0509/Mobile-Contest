using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    private Vector3 target = new Vector3 (Random.Range(-83f, 83f), 0f,0f);
    private short state = 0;

    private float basic_chance = 9;
    private float ultimate_chance = 0;

    void Update()
    {
        if(state == 0 && transform.position == target)
        {
            float stay_time = Random.Range(0f, 10f);

            while(stay_time <= 0)
            {
                int use_skill = Random.Range(1, 100);

                if (10 >= use_skill && use_skill >= basic_chance)
                {
                    GameObject.Find("SkillManager").GetComponent<SkillManager>().Use_basic();
                }
                else if (ultimate_chance >= use_skill && use_skill > 0)
                {
                    //use skill
                }
                stay_time -= Time.deltaTime;
            }
        }
        else
        {
            
        }
    }
}