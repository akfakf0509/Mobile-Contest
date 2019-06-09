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

    private readonly float basic_cooltime = 2f;
    private readonly float avo_cooltime = 5f;
    private readonly float ultimate_cooltime = 25f;

    // Update is called once per frame 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && basicCooltime)
        {
            Use_basic();
        }
        if (Input.GetKeyDown(KeyCode.W) && avoCooltime)
        {
            Use_avo();
        }
        if (Input.GetKeyDown(KeyCode.E) && ultimateCooltime)
        {
            Use_ultimate();
        }
        if (doing)
            StartCoroutine("TurnDoing");
    }

    public void Use_basic()
    {
        doing = true;
        Instantiate(basic_skill, position.transform.position, position.transform.rotation);
        basicCooltime = false;
        StartCoroutine("BasicCooltime");
    }

    public void Use_avo()
    {
        doing = true;
        Instantiate(avo_skill, position.transform.position, position.transform.rotation);
        avoCooltime = false;
        StartCoroutine("AvoCooltime");
    }

    public void Use_ultimate()
    {
        doing = true;
        Instantiate(Ultimate_skill, position.transform.position, position.transform.rotation);
        ultimateCooltime = false;
        StartCoroutine("UltimateCooltime");
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
    IEnumerator TurnDoing()
    {
        yield return new WaitForSeconds(0.1f);
        doing = false;
    }
}
