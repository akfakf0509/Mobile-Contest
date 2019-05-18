using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public GameObject positon;
    private int mode = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (mode)
        {
            case 0:
                transform.RotateAround(positon.transform.position, Vector3.forward * Time.deltaTime, 1);
                if (transform.rotation.z * 100 > 60)
                    mode++;
                break;
            case 1:
                transform.RotateAround(positon.transform.position, Vector3.back * Time.deltaTime, 1);
                if (transform.rotation.z * 100 < -60)
                    mode = 0;
                break;
        }
    }
}
