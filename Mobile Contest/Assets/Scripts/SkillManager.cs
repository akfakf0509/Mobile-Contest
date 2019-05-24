using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillManager : MonoBehaviour
{
    public GameObject basic_skill;
    public GameObject avo_skill;
    public GameObject Ultimate_skill;
    public GameObject position;

    private float basic_skill_cooltime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
 
    // Update is called once per frame
    void Update()
    {
        basic_skill_cooltime-=Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && basic_skill_cooltime < 0)
        {
            Instantiate(basic_skill, position.transform.position, position.transform.rotation);
            basic_skill_cooltime = 2f;
        }
    }
}
