using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground : MonoBehaviour
{
    public GameObject genplatform;
    public GameObject[] platforms;
    public Transform genpoint;
    public float gap;
    private float platwidth;
    private float[] platformwidth;

    public float gapmin;
    public float gapmax;

    private int platselect;

    private coingenerate generatedcoin;
    public float cointhreshold;

    // Start is called before the first frame update
    void Start()
    {
        //platwidth = genplatform.GetComponent<BoxCollider2D>().size.x;
        platformwidth = new float[platforms.Length];

        for(int i = 0; i < platforms.Length; i++)
        {
            platformwidth[i] = platforms[i].GetComponent<BoxCollider2D>().size.x;
        }
        generatedcoin = FindObjectOfType<coingenerate>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < genpoint.position.x)
        {
            gap = Random.Range(gapmin, gapmax);
            platselect = Random.Range(0, platforms.Length);


            //transform.position = new Vector3(transform.position.x + platwidth + gap, transform.position.y, transform.position.z);
            transform.position = new Vector3(transform.position.x + (platformwidth[platselect]/2 )+ gap, transform.position.y, transform.position.z);
            // Instantiate(genplatform, transform.position, transform.rotation);
          
            Instantiate(platforms[platselect], transform.position, transform.rotation);

            if(Random.Range(0f,100f)< cointhreshold)
            {
                generatedcoin.gencoins(new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z));
            }
    
            transform.position = new Vector3(transform.position.x + (platformwidth[platselect] / 2), transform.position.y, transform.position.z);
        }
        
    }
}
