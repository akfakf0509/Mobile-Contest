using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillManager : MonoBehaviour
{
    public GameObject basic_skill;
    public GameObject avo_skill;
    public GameObject Ultimate_skill;
    public GameObject position;

    // Start is called before the first frame update
    void Start()
    {
        
    }
 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Instantiate(basic_skill, position.transform.position, position.transform.rotation);
    }
}
