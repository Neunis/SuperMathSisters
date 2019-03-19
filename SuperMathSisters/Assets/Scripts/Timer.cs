using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    //currently set to 10 seconds for testing purposes
    public static float timeLeft = 10f;
    private bool completed = false;

    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<Text>();
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (completed)
            return;

        //this gives us the amount of time since time was started
        float t = Time.time - startTime;
        //this removes decimals and provides minutes
        string minutes = ((int) t / 60).ToString();
        //same principle as minutes but with seconds
        //f2 within () just defines that only 2 decimals will be shown as a float
        string seconds = (t % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;

       /* timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            timeLeft = 0;
            timerText.text = "Time Left: " + Mathf.Round(timeLeft);
        }
        */

    }

    public void endResult()
    {
        completed = true;
        timerText.color = Color.red;

    }
}
