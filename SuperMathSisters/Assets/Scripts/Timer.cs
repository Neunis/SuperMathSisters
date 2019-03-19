using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    private float endTime;
    //currently set to 10 seconds for testing purposes
    public static float timeLeft = 30f;
    private bool completed = false;

    // Start is called before the first frame update
    void Start()
    {
        //timerText = GetComponent<Text>(); // this line was cause a null reference see https://answers.unity.com/questions/1352355/null-reference-exception-to-a-non-null-text-object.html
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

        if (timerText != null) { // check to see if the object is null or not
            if (Convert.ToInt32(minutes) > 1.0 ) // if there is minute in the timer, then display it otherwise dont
            {
                timerText.text = minutes + ":" + seconds;

            }
            else
            {
                timerText.text = seconds;

            }
        }
        else
        {
            Debug.Log("Timer is null");
        }
        /* timeLeft -= Time.deltaTime;
         if (timeLeft < 0)
         {
             timeLeft = 0;
             timerText.text = "Time Left: " + Mathf.Round(timeLeft);
         }
         */

    }

    public void EndResult()
    {
        completed = true;
        timerText.color = Color.yellow;

    }

    public bool GetCompleted() // I use this function to get the status the timer. if true then the time is up was my understanding. 
    {
        return completed;
    }
}
