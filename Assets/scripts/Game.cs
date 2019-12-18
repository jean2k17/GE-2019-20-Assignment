using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Transform generatepoint;
    private Vector3 startpoint;
    public Player gameplayer;
    private Vector3 playerstartpoint;
    private delete[] platforms;
    private Score newscore;
    // Start is called before the first frame update
    void Start()
    {
        startpoint = generatepoint.position;
        playerstartpoint = gameplayer.transform.position;
        newscore = FindObjectOfType<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RestartGame()
    {
        
        StartCoroutine("restartcoroutine");
    }
    public IEnumerator restartcoroutine ()
    {
        newscore.increasescore = false;
        gameplayer.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        platforms = FindObjectsOfType<delete>();
        for(int i=0; i<platforms.Length; i++)
        {
            platforms[i].gameObject.SetActive(false);
            //Destroy(platforms[i].gameObject);
        }
        gameplayer.transform.position = playerstartpoint;
        generatepoint.position = startpoint;
        gameplayer.gameObject.SetActive(true);

        newscore.scorecount = 0;
        newscore.increasescore = true;
    }
}
