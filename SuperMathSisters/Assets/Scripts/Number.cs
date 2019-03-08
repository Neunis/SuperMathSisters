using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Number : MonoBehaviour
{
    bool isPicked = false;
    public Text number;
    GameObject numObj;
    bool inCollider;
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
    private void Update() //fixedupdate 
    {
        if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            if (this.getInCollider() )
            {
                this.isPicked = !isPicked;
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
            Debug.Log(collision.gameObject.name + " : " + gameObject.name + " : " + Time.time);
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
}
