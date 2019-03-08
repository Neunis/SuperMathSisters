using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Number : MonoBehaviour
{
    bool inCollider = false;
    bool isPicked = false;
    public Text number;
    GameObject numObj;

    private void Start()
    {

    }

    // Start is called before the first frame update
    private void Update() //fixedupdate 
    {
       if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.KeypadEnter) && this.inCollider)
        {
            this.isPicked = !isPicked;
            Debug.Log("  isPicked = true;");
            //number = gameObject.GetComponent<Text>();
            if (this.isPicked)
            {
                //this.number.color = Color.black;
            }
            else
            {
                //this.number.color = Color.white;
            }



            switch (this.gameObject.name)
            {
                case "collision6":
                    numObj = GameObject.Find("Num6");
                    numObj.GetComponent<Text>().color = Color.black;
                    break;
                case "collision4":
                    numObj = GameObject.Find("Num4");
                    numObj.GetComponent<Text>().color = Color.black;
                    break;
                case "collision3":
                    numObj = GameObject.Find("Num3");
                    numObj.GetComponent<Text>().color = Color.black;
                    break;
                case "collision1":
                    numObj = GameObject.Find("Num1");
                    numObj.GetComponent<Text>().color = Color.black;
                    break;
                default:
                    Debug.Log("cant find that game object name");
                    break;
            }




        } // end if
    }

 


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Character") {
            Debug.Log(collision.gameObject.name + " : " + gameObject.name + " : " + Time.time);
            this.inCollider = true;
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Character")
        {
            this.inCollider = false;
        }
    }

    public bool getIsPicked()
    {
        return this.isPicked;
    }
}
