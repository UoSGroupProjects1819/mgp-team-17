using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class storeTelePos : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 pos1;
    public Vector3 pos2;
    public int teleportCD;
    void Start()
    {
        GameObject enter = GameObject.Find("Teleporter-enter");
        GameObject exit = GameObject.Find("Teleporter-exit");
        if (enter != null)
        {
            pos1 = enter.transform.position;
            pos1.y += 1.5f;
        }
        if (exit != null)
        {
            pos2 = exit.transform.position;
            pos2.y += 1.5f;

        }
    }

    // Update is called once per frame
    void Update()
    {
       




    }
}
