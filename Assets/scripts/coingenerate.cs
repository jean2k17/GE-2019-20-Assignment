using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coingenerate : MonoBehaviour
{
    //public Coins[] coinarray;
    public objectpool coinpool;
    public float coindistance;
 
    public void gencoins(Vector3 startPosition)
    {
        GameObject coin1 = coinpool.GetPoolObject();
        coin1.transform.position = startPosition;
        coin1.SetActive(true);

        /*GameObject coin2 = coinpool.GetPoolObject();
        coin2.transform.position = new Vector3(startPosition.x - coindistance;
        coin2.SetActive(true);*/
    }
}
