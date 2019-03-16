using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject target;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Vector3 posi = target.gameObject.transform.position;
            collision.gameObject.transform.position = posi;
            Debug.Log("ana");
        }
    }
}
