using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour
{
    //serialized field is the same as private however it also allow it to be seen in editor w/in Unity
    [SerializeField] Text countdownTxt;

    float currentTime = 0f;
    float startTime = 30f;
    bool paused; //if true then the game is paused
    bool counted;

    void Start()
    {
        currentTime = startTime;
        counted = false;
        paused = false;
    }

    void Update()
    {
        //time is decreade not on every frame but by Time fxn
        if (!paused) { //if the pause menu is up then dont count down
            currentTime -= 1 * Time.deltaTime;
            countdownTxt.text = currentTime.ToString("0");
        }
        if (currentTime >= 10)
        {
            countdownTxt.color = Color.black;
        }
        else
        {
            countdownTxt.color = Color.red;
        }

        if(currentTime <= 0)
        {
            currentTime = 0;
            counted = true;

        }

    }

    public void SetPaused(bool param)
    {
        paused = param;
    }

    public bool GetCompleted() // I use this function to get the status the timer. if true then the time is up was my understanding. 
    {
        return counted;
   }
}
