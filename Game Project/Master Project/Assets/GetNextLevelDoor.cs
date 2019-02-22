using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetNextLevelDoor : MonoBehaviour
{
    public Transform key;
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

            Instantiate(key, new Vector3(20, 5, 0), Quaternion.identity);
        }


    }
}
