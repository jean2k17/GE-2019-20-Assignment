using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete : MonoBehaviour
{
    public GameObject deletepoint;
    // Start is called before the first frame update
    void Start()
    {
        deletepoint = GameObject.Find("deletepoint");
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < deletepoint.transform.position.x)
        {
            //Destroy(gameObject);
            gameObject.SetActive(true);
        }
    }
}
