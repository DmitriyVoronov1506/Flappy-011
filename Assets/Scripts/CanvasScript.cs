using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{
    [SerializeField]
    private TMPro.TextMeshProUGUI Clock;

    private float gameTime;

    void Start()
    {
        Clock.text = "";
        gameTime = 0f;
    }

    void Update()
    {
        gameTime += Time.deltaTime;

        int seconds = (int)(((int)(gameTime * 10)) / 10f);

        var timeFromSeconds = TimeSpan.FromSeconds(seconds);

        string time = "";

        if(timeFromSeconds.Hours >= 1)
        {
            time += timeFromSeconds.Hours.ToString() + ":";
        }
        else
        {
            time += "00:";
        }

        if(timeFromSeconds.Minutes >= 1)
        {
            time += timeFromSeconds.Minutes.ToString() + ":";
        }
        else
        {
            time += "00:";
        }

        time += timeFromSeconds.Seconds.ToString();

        Clock.text = time;
    }
}
