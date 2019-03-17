using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    GameObject playerr;
    
    public GameObject target;
    private void Start()
    {
         playerr = GameObject.Find("Player");

    }
   


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player" )
        {
            Vector3 posi = target.gameObject.transform.position;
            collision.gameObject.transform.position = posi;
           
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
