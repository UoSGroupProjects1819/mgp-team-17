using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Teleport : MonoBehaviour
{
    
   // public float teleportCooldown;
    public GameObject TeleportBarEnter;
    public GameObject TeleportBarExit;
    public GameObject target;


    private void Start()
    {
        
       

    }
  



    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player" )
        {
            Vector3 posi = target.gameObject.transform.position;
            collision.gameObject.transform.position = posi;


            Instantiate(TeleportBarEnter);
            Instantiate(TeleportBarExit);

            


            StartCoroutine(MyCoroutine());

        }
    
    }
    


    IEnumerator MyCoroutine()
    {
        

        target.gameObject.SetActive(false);


        yield return new WaitForSeconds(GameObject.FindGameObjectWithTag("Player").GetComponent<storeTelePos>().teleportCD);

    
        
        target.gameObject.SetActive(true);

    }

}
