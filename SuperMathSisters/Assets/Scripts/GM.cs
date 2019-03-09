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
    bool didWinGame = false; // this flag is to know if the player won the game

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //hide the mouse
        Cursor.visible = false;
        Menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Menu.activeInHierarchy == true)
            {
                Menu.SetActive(false);
                character.SetActive(true);
            }
            else
            {
                Menu.SetActive(true);
                character.SetActive(false);
            }
        }

        if (didWinGame)
        {
            Debug.Log("YOU WIN!");
            this.endLevelMenuPopUp("Well Done!");

        }
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

    public void endLevelMenuPopUp(string title)
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

    public void returnToMainMenu()
    {
        SceneManager.LoadScene("Main_Level");

    }

    public void restartLevel()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
