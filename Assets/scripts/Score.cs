using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoretext;
    public Text highscoretext;
    public float scorecount;
    public float highscorecount;
    public float pointspersecond;
    public bool increasescore;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("High Score"))
        {
            highscorecount = PlayerPrefs.GetFloat("High Score");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (increasescore)
        {
            scorecount += pointspersecond * Time.deltaTime;
        }
        if(scorecount > highscorecount)
        {
            highscorecount = scorecount;
            PlayerPrefs.SetFloat("High Score", highscorecount);
        }
        scoretext.text = "Score: " + Mathf.Round(scorecount);
        highscoretext.text = "High Score: " + Mathf.Round(highscorecount);
    }
}
