using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class telebarEnter : MonoBehaviour

{
    public Slider slider;
    GameObject teleport;
    private void Start()
    {
        gameObject.GetComponent<Slider>().value = 0;
        teleport = GameObject.Find("Teleporter-enter");
    }


    // Update is called once per frame
    void Update()
    {

        Vector3 pos = teleport.transform.position;
        pos.y += 1.5f;

        gameObject.transform.position = pos;
        Debug.Log("merge");
        gameObject.GetComponent<Slider>().value += 1/teleport.GetComponent<Teleport>().teleportCooldown * Time.deltaTime;
        Destroy(gameObject, teleport.GetComponent<Teleport>().teleportCooldown);
        

    }
    
    
}
