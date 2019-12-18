using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour

{
    public Player character;
    private Vector3 lastposition;
    private float distance;
    // Start is called before the first frame update
    void Start()
    {
        character = FindObjectOfType<Player>();
        lastposition = character.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        distance = character.transform.position.x - lastposition.x;

        transform.position = new Vector3(transform.position.x + distance, transform.position.y, transform.position.z);

        lastposition = character.transform.position;
    }
}
