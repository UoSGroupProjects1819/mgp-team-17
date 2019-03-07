using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetNextLevelDoor : MonoBehaviour
{
    public GameObject key;
    public GameObject wallToDestroy;
    public Vector3 NextLevelDoorCoords;
    public GameObject wallToActivate;
     
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.keys += 1;
            //Instantiate(key, NextLevelDoorCoords, Quaternion.identity);
            Destroy(gameObject);
            Destroy(wallToDestroy);

            wallToActivate.SetActive(true);
        }


    }

}
