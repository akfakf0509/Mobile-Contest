using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillManager : MonoBehaviour
{
    public GameObject player_basic;
    public GameObject player_ultimate;

    public float player_basic_damge = 0.04f;
    public float player_basic_cooltime = 3;

    public float player_ultimate_damge = 0.065f;
    public float player_ultimate_cooltime = 20;

    public bool player_basic_use = true;
    public bool player_ultimate_use = true;

    public void Use_player_basic(Vector3 vector3, Quaternion quaternion, bool use_cooltime)
    {
        if (use_cooltime)
        {
            if (player_basic_use)
            {
                Instantiate(player_basic, vector3, quaternion);
                player_basic_use = false;
                StartCoroutine(Player_basic_runCool());
            }
        }
        else
        {
            Instantiate(player_basic, vector3, quaternion);
        }
    }

    public void Use_player_ultimate(Vector3 vector3, Quaternion quaternion, bool use_cooltime)
    {
        if (use_cooltime)
        {
            if (player_ultimate_use)
            {
                Instantiate(player_ultimate, vector3, quaternion);
                player_ultimate_use = false;
                StartCoroutine(Player_ultimate_runCool());
            }
        }
        else
        {
            Instantiate(player_ultimate, vector3, quaternion);
        }
    }

    IEnumerator Player_basic_runCool()
    {
        yield return new WaitForSeconds(player_basic_cooltime);
        player_basic_use = true;
    }

    IEnumerator Player_ultimate_runCool()
    {
        yield return new WaitForSeconds(player_ultimate_cooltime);
        player_ultimate_use = true;
    }
}
