using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public PlayerMovement move;
    void onCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.GetComponent<Collider>().tag == "obs")
        {
            move.enabled = false;
        }
    } 
}
