using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillManager : MonoBehaviour
{
    public GameObject basic_skill;
    public GameObject avo_skill;
    public GameObject Ultimate_skill;
    public GameObject position;

    [HideInInspector]
    public bool doing = false;
    private bool basicCooltime = true;
    private bool avoCooltime = true;
    private bool ultimateCooltime = true;

    private float basic_cooltime = 2f;
    private float avo_cooltime = 5f;
    private float ultimate_cooltime = 25f;

    // Update is called once per frame 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && basicCooltime)
        {
            doing = true;
            Instantiate(basic_skill, position.transform.position, position.transform.rotation);
            basicCooltime = false;
            StartCoroutine("BasicCooltime");
        }
        if (Input.GetKeyDown(KeyCode.W) && avoCooltime)
        {
            doing = true;
            Instantiate(avo_skill, position.transform.position, position.transform.rotation);
            avoCooltime = false;
            StartCoroutine("AvoCooltime");
        }
        if (Input.GetKeyDown(KeyCode.E) && ultimateCooltime)
        {
            doing = true;
            Instantiate(Ultimate_skill, position.transform.position, position.transform.rotation);
            basicCooltime = false;
            StartCoroutine("UltimateCooltime");
        }
        if (doing)
            StartCoroutine("turnDoing");
    }

    IEnumerator BasicCooltime()
    {
        yield return new WaitForSeconds(basic_cooltime);
        basicCooltime = true;
    }
    
    IEnumerator AvoCooltime()
    {
        yield return new WaitForSeconds(avo_cooltime);
        avoCooltime = true;
    }
    IEnumerator UltimateCooltime()
    {
        yield return new WaitForSeconds(ultimate_cooltime);
        ultimateCooltime = true;
    }
    IEnumerator turnDoing()
    {
        yield return new WaitForSeconds(0.1f);
        doing = false;
    }
}
