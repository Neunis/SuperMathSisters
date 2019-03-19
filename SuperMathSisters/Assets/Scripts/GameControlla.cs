using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControlla : MonoBehaviour
{
    public GameObject timeLeft;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Timer.timeLeft <= 0)
        {
            Time.timeScale = 0;
            timeLeft.gameObject.SetActive(true);
            //connect game level to restart screen
        }
    }

    public void restartScreen() // what is this function for -k
    {
        timeLeft.gameObject.SetActive(false);
        //restart load screen appears
        Time.timeScale = 1;
        Timer.timeLeft = 10f;
        //for testing purposes
        SceneManager.LoadScene("Main Level"); 
    }
}
