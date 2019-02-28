using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetNextLevelDoor : MonoBehaviour
{
    public GameObject key;
    public GameObject wallToDestroy;
    public Vector3 NextLevelDoorCoords;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "player")
        {

            Instantiate(key, NextLevelDoorCoords, Quaternion.identity);
            Destroy(wallToDestroy);
        }


    }
}
