using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//this script handles the number and selection of the number
public class Number : MonoBehaviour
{
    bool isPicked = false;
    public Text number;
    GameObject numObj;
    bool inCollider;
    public string ID;
    int numbersListSize;
    private void Start()
    {
        inCollider = false;

    }
    
    void setInCollider(bool param)
    {
        inCollider = param;
    }

    bool getInCollider()
    {
        return inCollider;
    }
    // Start is called before the first frame update
    //handles the logic for when the character is above the number, selects the number, and the number changes color. calls the equation checker when a number is selected or deselected
    private void Update() //fixedupdate 
    {

        if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Return))
        {
            if (this.getInCollider())
            {
                this.isPicked = !isPicked;
                GameObject equation = GameObject.Find("numberHandler");
                if (equation != null)
                {
                    equation.GetComponent<NumberSelection>().UpdateEquation(this.gameObject); // send the info to the equation handler
                }
                //Debug.Log("numbersListSize " + numbersListSize);

                    if (this.isPicked)
                    {
                        //Debug.Log("  isPicked = true;");
                        this.number.color = Color.black;
                        this.setIsPicked(true);
                         
                    }
                    else
                    {
                        this.setIsPicked(false);
                        //Debug.Log("  isPicked = false;");
                        this.number.color = Color.white;
                    }
                

            }


        } // end if
    }




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Character") {
            //Debug.Log(collision.gameObject.name + " : " + gameObject.name + " : " + Time.time);
            //this.inCollider = true;
            this.setInCollider(true);
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        // this.inCollider = false;
        this.setInCollider(false);


    }

    public bool getIsPicked()
    {
        return this.isPicked;
    }
    void setIsPicked(bool param)
    {
        isPicked = param;
    }
    public string getID()
    {
        return ID;
    }
}
