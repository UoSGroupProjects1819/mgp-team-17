using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AImovement : MonoBehaviour
{
    //this is the first marker enemy will go to
    int target;
    public Vector3[] markers;
    public float speed;
    //this is where enemy will stop
    public int whereToStop;
    //this is where it will start again
    public int whereToStart;
    


    bool b;
    int i;
    void Start()
    {
        target = whereToStart;
        speed = 0.1f;

        //Put however many Empty game objects in your scene for position markers and name them "marker0" and "marker1" and "marker2"

        b = false;
        i = 0;
        while (!b) { if (GameObject.Find("marker" + i)) { i++; } else { b = true; } }
        markers = new Vector3[i];
        while (i > 0)
        {
            i--; markers[i] = GameObject.Find("marker" + i).transform.position;

        }

    }


    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, markers[target], speed*Time.deltaTime );
        if (transform.position == markers[target])
        {
            target++;
            if (target == whereToStop+1) { target = whereToStart; }
        }

    }
}
