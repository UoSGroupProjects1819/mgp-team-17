using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    GameObject playerr;
    float teleportercooldown;
    public GameObject target;
    private void Start()
    {
         playerr = GameObject.Find("Player");

    }
    private void Update()
    {
        if (teleportercooldown > 0)
            teleportercooldown -= Time.deltaTime;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player" && teleportercooldown <= 0)
        {
            Vector3 posi = target.gameObject.transform.position;
            collision.gameObject.transform.position = posi;
            //this.teleportercooldown = 0.1f;
            StartCoroutine(MyCoroutine());

        }
    
    }
    IEnumerator MyCoroutine()
    {

        target.gameObject.SetActive(false);
        

        yield return new WaitForSeconds(0.1f);

        target.gameObject.SetActive(true);
        
    }

}
