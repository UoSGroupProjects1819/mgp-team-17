using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

    // Use this for initialization
    public Rigidbody2D rb;
    public float thrust;
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        


    }
    private void FixedUpdate()
    {
        if (Input.GetKey("a"))
        {
            rb.AddForce(Vector3.left* thrust * Time.deltaTime );

        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(Vector3.right * thrust * Time.deltaTime );

        }
        if (Input.GetKey("w"))
        {
            //rb.AddForce(Vector3.up * thrust);
            rb.AddForce(Vector3.up * thrust/100  );

        }
        if (Input.GetKey("s"))
        {
            //rb.AddForce(Vector3.down * thrust);
            rb.AddForce(Vector3.down * thrust/100 );

        }
    }
}
