using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    // Start is called before the first frame update
    /*void Start()
    {
        rb.AddForce(0, 200, 500);
    }*/
    public float speed = 5.0f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            //rb.AddForce(0, 0, 2000 * Time.deltaTime);
            Vector3 p = transform.position;
            p.x -= speed * Time.deltaTime;
            transform.position = p;
            p -= Vector3.right * speed * Time.deltaTime;
            transform.position = p;
        }
        if (Input.GetKey("w"))
        {
            //rb.AddForce(0, 0, 2000 * Time.deltaTime);
            Vector3 p = transform.position;
            p.z += speed * Time.deltaTime;
            transform.position = p;
            p += Vector3.forward * speed * Time.deltaTime;
            transform.position = p;
        }
        if (Input.GetKey("d"))
        {
            //rb.AddForce(0, 0, 2000 * Time.deltaTime);
            Vector3 p = transform.position;
            p.x += speed * Time.deltaTime;
            transform.position = p;
            p += Vector3.right * speed * Time.deltaTime;
            transform.position = p;
        }
        if (Input.GetKey("s"))
        {
            //rb.AddForce(0, 0, 2000 * Time.deltaTime);
            Vector3 p = transform.position;
            p.z -= speed * Time.deltaTime;
            transform.position = p;
            p -= Vector3.forward * speed * Time.deltaTime;
            transform.position = p;
        }
    }
}
