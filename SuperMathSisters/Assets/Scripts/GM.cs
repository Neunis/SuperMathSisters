using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GM : MonoBehaviour
{
    public GameObject Menu;
    public GameObject character;
    public GameObject restartMenu;
    public GameObject TimerObject;
    bool didWinGame = false; // this flag is to know if the player won the game

    // Start is called before the first frame update
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked; //hide the mouse
       // Cursor.visible = false;
        //Menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Menu.activeInHierarchy == true) // the menu is not there
            {
                TimerObject.GetComponent<Timer>().SetPaused(false);
                Menu.SetActive(false);
                character.SetActive(true);
            }
            else // menu is there
            {
                TimerObject.GetComponent<Timer>().SetPaused(true);
                Menu.SetActive(true);
                character.SetActive(false);
            }
        }

        if (didWinGame)
        {
            Debug.Log("YOU WIN!");
            this.endLevelMenuPopUp("Well Done!");
            //need to stop timer
            TimerObject.GetComponent<Timer>().SetPaused(true);

        }

        if (TimerObject.GetComponent<Timer>().GetCompleted())// the timer is up and the game is done. 
        {
            this.endLevelMenuPopUp("Try Again!");
            //Debug.Log("TIMER ENDED");
        }
    }

    public void PauseTimerFromGM()
    {
        TimerObject.GetComponent<Timer>().SetPaused(true);
    }

    public void Resume()
    {
        Menu.SetActive(false);
        character.SetActive(true);
    }

    public void Instructions()
    {

    }


    public void setDidWinGame(bool param)
    {
        didWinGame = param;
    }

    public void endLevelMenuPopUp(string title) // pass in the text to display to user, Try Again or Well Done! call this function to make the game end and present to the user their choices
    {
        restartMenu.SetActive(true);
        character.SetActive(false);

        GameObject popUp = GameObject.Find("winOrLoseText");
        if (popUp != null)
        {
            popUp.GetComponent<Text>().text = title;

        }

    }

    public void playNextLevel(string LevelName) //have the button call this function with the name level string
    {
        SceneManager.LoadScene(LevelName);
    }

    public void returnToMainMenu() // called when the main menu is clicked
    {
        SceneManager.LoadScene("Main_Level");

    }

    public void restartLevel() // called when the restart button the menu is clicked
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
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
