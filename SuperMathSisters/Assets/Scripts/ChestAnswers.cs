using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestAnswers : MonoBehaviour
{
    private Button chest;
    string answer = "1";
    bool inCollider;
    public GameObject GM;

    //private reference to UI button
    void Awake()
    {
        chest = GetComponent<Button>();
        inCollider = false;

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Return))
        {
            //Debug.Log("You have pressed a selection key this.getInCollider() =  " + this.getInCollider());
            if (this.getInCollider())
            {
                //Debug.Log(" if (this.getInCollider())  : " + gameObject.name + " : " + Time.time);
                OutlineColorSelection(chest.colors.pressedColor);
                if (gameObject.name.Equals(answer))
                {
                    //Debug.Log("you win!");
                    GM.GetComponent<GM>().setDidWinGame(true);

                }
                else
                {
                   // Debug.Log("you lost");
                    GM.GetComponent<GM>().endLevelMenuPopUp("Try Again!");
                    GM.GetComponent<GM>().PauseTimerFromGM();

                }

            }
        }
    }


    //usability feature that outlines selection for user respectively
    void OutlineColorSelection(Color color)
    {
        Graphic graphic = GetComponent<Graphic>();
        graphic.CrossFadeColor(color, chest.colors.fadeDuration, true, true);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Character")
        { // checks to make sure the that critter is colliding
            //Debug.Log("OnTriggerEnter "+collision.gameObject.name + " : " + gameObject.name + " : " + Time.time);
            //this.inCollider = true;
            this.setInCollider(true);
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //Debug.Log("OnTriggerExit2D " + collision.gameObject.name + " : " + gameObject.name + " : " + Time.time);

        // this.inCollider = false;
        this.setInCollider(false);


    }

    void setInCollider(bool param)
    {
        //Debug.Log("setINCollider param = " + param);
        inCollider = param;
    }

    bool getInCollider()
    {
        return inCollider;
    }
}


