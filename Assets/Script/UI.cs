using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    public TMP_Text scoreText, timerText, liveText, FinalScore;
   
    public static UI institite;

    public float Timer = 0;

    public bool isPlay;
    // Start is called before the first frame update
    void Start()
    {
        if (institite == null)
            institite = this;
    }

    // Update is called once per frame
    void Update()
    {
        //scoreText.text = "SCORE: " + Player.institite.score.ToString();
        if (isPlay == true)
        {
            Timer += Time.deltaTime;

            timerText.SetText("Time: " + Timer.ToString("##"));
        }
    }

    public void StartGame()
    {
        isPlay = true;
    }
}
