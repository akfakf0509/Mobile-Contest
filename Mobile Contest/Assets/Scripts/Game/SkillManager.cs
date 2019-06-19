using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillManager : MonoBehaviour
{
    public GameObject player_basic;
    
    public float player_basic_damge = 0.7f;
    public float player_basic_cooltime = 3;

    public bool player_basic_use = true;

    public void Use_player_basic(Vector3 vector3, Quaternion quaternion)
    {
        if (player_basic_use)
        {
            GameObject skill = Instantiate(player_basic, vector3, quaternion);
            skill.transform.position = new Vector3(skill.transform.position.x, skill.transform.position.y, -30);
            player_basic_use = false;
            StartCoroutine(Player_basic_runCool());
        }
    }

    IEnumerator Player_basic_runCool()
    {
        yield return new WaitForSeconds(player_basic_cooltime);
        player_basic_use = true;
    }
}
