using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetNextLevelDoor : MonoBehaviour
{
    public GameObject key;
    public GameObject wallToDestroy;
    public Vector3 NextLevelDoorCoords;
    public GameObject wallToActivate;
    public bool doYouWantToSpawnAnExit;
     
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.keys += 1;
            if (doYouWantToSpawnAnExit)
            {
                Instantiate(key, NextLevelDoorCoords, Quaternion.identity);
            }
            
            Destroy(gameObject);
            Destroy(wallToDestroy);
            if (wallToActivate != null)
            {
                wallToActivate.SetActive(true);
            }
            
        }


    }

}
