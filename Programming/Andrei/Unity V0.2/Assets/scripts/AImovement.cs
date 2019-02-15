using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AImovement : MonoBehaviour
{
    public int target;
    public Vector3[] markers;
    public float speed;


    bool b;
    int i;
    void Start()
    {

        //Put however many Empty game objects in your scene for position markers and name them "marker1" and "marker2" and "marker3"

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
        transform.position = Vector3.MoveTowards(transform.position, markers[target], speed );
        if (transform.position == markers[target])
        {
            target++;
            if (target == markers.Length) { target = 0; }
        }

    }
}
