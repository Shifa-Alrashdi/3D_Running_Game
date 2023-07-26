using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    public TMP_Text scoreText, timerText;
   
    public static UI institite;

    float Timer = 0;

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

        Timer += Time.deltaTime;

        timerText.SetText("Time: " + Timer.ToString("##"));

    }

    public void StartGame()
    {
        print("press button");
    }
}
