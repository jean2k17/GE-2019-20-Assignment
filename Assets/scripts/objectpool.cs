using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectpool : MonoBehaviour
{
    public GameObject pooledobject;
    public int pooledamount;
    List<GameObject> pooledobjects;
    // Start is called before the first frame update
    void Start()
    {
        pooledobjects = new List<GameObject>();

        for (int i=0; i < pooledamount; i++)
        {
            GameObject obj = (GameObject)Instantiate(pooledobject);
            obj.SetActive(false);
            pooledobjects.Add(obj);

        }
    } 

    public GameObject GetPoolObject()
    {
        for (int i = 0; i < pooledobjects.Count; i++)
        {
            if(!pooledobjects[i].activeInHierarchy)
            {
                return pooledobjects[i];
            }
        }

        GameObject obj = (GameObject)Instantiate(pooledobject);
        obj.SetActive(false);
        pooledobjects.Add(obj);
        return obj;
    }
}
