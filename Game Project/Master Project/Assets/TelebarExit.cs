using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TelebarExit : MonoBehaviour
{
    GameObject teleport;
    public Slider slider;
    private void Start()
    {
        gameObject.GetComponent<Slider>().value = 0;
        teleport = GameObject.Find("Teleporter-exit");
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 pos = teleport.transform.position;
        pos.y += 1.5f;

        gameObject.transform.position = pos;
        gameObject.GetComponent<Slider>().value += 1 / teleport.GetComponent<Teleport>().teleportCooldown * Time.deltaTime;
        Destroy(gameObject, teleport.GetComponent<Teleport>().teleportCooldown);
    }
  
}

