using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTime : MonoBehaviour
{
    public float time = 100f;
    public Text timeCount;

    public float killCount;
    public Text killCounter;

    public float highScore = 0f;
    public Text HighScore;

    // Start is called before the first frame update
    void Start()
    {
        timeCount.text = time.ToString();
        highScore = PlayerPrefs.GetFloat("highscore", highScore);
        HighScore.text = "HS: " + highScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timeCount.text = Mathf.Round(time).ToString();

        if (highScore <= killCount)
        {
            highScore = killCount;
            HighScore.text = "HS: " + highScore.ToString();
        }
        PlayerPrefs.SetFloat("highscore", highScore);
        PlayerPrefs.Save();

        if (time <= 0f)
        {
            GameObject.Find("Menus").GetComponent<Menus>().GameOver();
        }

        if (killCount >= 1000f)
        {
            GameObject.Find("Menus").GetComponent<Menus>().Victory();
        }
    }
}
