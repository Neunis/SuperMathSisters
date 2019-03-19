using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treasure : MonoBehaviour
{
    private GameObject CorrectAnswerBox;
    //once char collides with the correct object the program will send
    //a message to the game to change its false var to true
    private void OnTriggerEnter(Collider other)
    {
        //Add your condition or class that ends your game
        //based on critter
        GameObject.Find("Character").SendMessage("EndResult");
    }
}
