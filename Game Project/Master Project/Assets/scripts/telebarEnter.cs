using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class telebarEnter : MonoBehaviour

{
    public Slider slider;
    float valueDate;
    float valueDate1;



    private void Start()
    {
        gameObject.GetComponent<Slider>().value = 0;
        valueDate =GameObject.FindGameObjectWithTag("Player").GetComponent<storeTelePos>().teleportCD;
   
        valueDate1 = 1 / valueDate;
 



    }


    // Update is called once per frame
    void Update()
    {

       

        gameObject.transform.position = GameObject.FindGameObjectWithTag("Player").GetComponent<storeTelePos>().pos1;
       
        gameObject.GetComponent<Slider>().value += valueDate1*Time.deltaTime ;
        Destroy(gameObject, GameObject.FindGameObjectWithTag("Player").GetComponent<storeTelePos>().teleportCD);
        

    }
    
    
}
