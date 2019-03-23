using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class telebarEnter : MonoBehaviour
    
{
    GameObject teleport;
    private void Start()
    {
        teleport = GameObject.Find("Teleporter-enter");
    }


    // Update is called once per frame
    void Update()
    {
      
        Vector3 pos = teleport.transform.position;
        pos.y += 1.5f;

        gameObject.transform.position = pos;
    }
}
