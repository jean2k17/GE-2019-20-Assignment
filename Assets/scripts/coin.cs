using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public int scoregain;
    private AudioSource coinSound;
    private Score scoremanage;
    // Start is called before the first frame update
    void Start()
    {
        scoremanage = FindObjectOfType<Score>();
        coinSound = GameObject.Find ("Coinsound").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "player")
        {
            scoremanage.scorecount += scoregain;
            gameObject.SetActive(false);
            coinSound.Play();
        }
    }
}
