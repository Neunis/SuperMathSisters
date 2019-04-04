using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        //this line allows scenes to be loaded based on an index instead of 
        //manually telling it which scenes to load
        //order is already set up in build settings
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        //tester to see if game quits since application.quit only fxns once built
        //for unity editor testing purposes
        //TODO:DELETE ONCE COMPLETED
        Debug.Log("Game Quitting"); 
        Application.Quit();
    }

    
}
