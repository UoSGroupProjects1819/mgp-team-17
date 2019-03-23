using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Teleport : MonoBehaviour
{
    
    public float teleportCooldown;
   public  GameObject barEnter;
    public GameObject barExit;
    

    public GameObject target;
    private void Start()
    {
       // barEnter = GameObject.Find("Teleporter-enter");
        //barExit = GameObject.Find("Teleporter-exit");

    }
   


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player" )
        {
            Vector3 posi = target.gameObject.transform.position;
            collision.gameObject.transform.position = posi;
            

            
            //barEnter.gameObject.GetComponentInChildren<telebarEnter>().BarWork();
           // barExit.GetComponent<TelebarExit>().BarWork();

         
            StartCoroutine(MyCoroutine());

        }
    
    }
    IEnumerator MyCoroutine()
    {
        Instantiate(barEnter);
        Instantiate(barExit);


        target.gameObject.SetActive(false);

      
        yield return new WaitForSeconds(teleportCooldown);

        DestroyImmediate(barEnter);
        DestroyImmediate(barExit);
        target.gameObject.SetActive(true);
        
    }

}
