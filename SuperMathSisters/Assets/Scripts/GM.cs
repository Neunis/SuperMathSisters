using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{
    public GameObject Menu;
    public GameObject character;
    bool didWinGame = false; // this flag is to know if the player won the game

    // Start is called before the first frame update
    void Start()
    {
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

    public void MainMenu()
    {

    }

    public void setDidWinGame(bool param)
    {
        didWinGame = param;
    }
}
