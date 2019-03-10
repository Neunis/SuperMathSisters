using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityScript.Lang;

// this script handles the equation checker and to see if the numbers equal the answer, removing and adding in the number when selected or deselected
public class NumberSelection : MonoBehaviour
{
    public Text left;
    public Text right;
    public GameObject GM;

    List<GameObject> numbers = new List<GameObject>(new GameObject[] { null, null });
    public int waitTimeForEquation;
    int answer = 10;
    // Start is called before the first frame update
    void Start()
    {
        numbers[0] = null;
        numbers[1] = null;

    }

    // Update is called once per frame
    void Update()
    {
        if (numbers[0] != null && numbers[1] != null)
        {
            int num0 = int.Parse(numbers[0].GetComponent<Number>().getID());
            int num1 = int.Parse(numbers[1].GetComponent<Number>().getID());

            StartCoroutine(waitForASec());
            if (num0 + num1 == answer) {
                GM.GetComponent<GM>().setDidWinGame(true);
            }

        }
    }
    IEnumerator waitForASec()
    {
       // print(Time.time);
        yield return new WaitForSeconds(waitTimeForEquation);
        //print(Time.time);
    }
   
    public bool isEquationFull()
    {
        int count = 0;
        for (int i = 0; i < numbers.Count; i++ )
        {
            if (numbers[i] != null)
            {
                count++;
            }
        }
        Debug.Log(" the count is " + count);
        if (count == 2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //need to send this function object to update array if there is a spot avail
    public void UpdateEquation(GameObject number)
    {
       // Debug.Log("inside the equation checker numbers.Count = " + numbers.Count);
        //check if there is space in the array
        if (numbers.Count <= 2)
        {
            //Debug.Log(" numbers.Count =  " + numbers.Count);
            //check to see if the GameObject passed in exists in the array already
            if (numbers.Contains(number))
            {
                // if the number exists remove (since this function is called when the button is pressed) 
                //numbers.Remove(number); dont remove...set to null
               
                int index = numbers.IndexOf(number);
               // Debug.Log("remove the number at index = " + index);
                numbers[index] = null;
                //need to make sure that when you remove an item from the array does it go back to null?
            }
            else // if not then add in the number
            {
               // Debug.Log("numbers.Contains(number) is false  numbers.Count = " + numbers.Count);
                for(int i = 0; i < numbers.Count; i++)
                {
                    //Debug.Log("inside the for loop to add in the number i = " + i);
                    if(numbers[i] == null)
                    {
                        numbers[i] = number;
                        //Debug.Log("numbers[i] = " + numbers[i]);
                        break;
                    }
                }
            }


            //update the display of function
         
                //if spot in the array is null, then fill with question mark
            if (numbers[0] == null)
            {
                    left.text = "?";
                    //Debug.Log("setting left " + 0 + " to ?" + " i = " + 0);
            }
            if (numbers[1] == null)
            {
                right.text = "?";
                //Debug.Log("setting right" + 1 + " to ?" + " i = " + 1);
            }

            //else fill with the number

            if (numbers[0] != null)
            {
                left.text = numbers[0].GetComponent<Number>().getID();
            }
            if (numbers[1] != null)
            {
                right.text = numbers[1].GetComponent<Number>().getID();
            } 
            //Debug.Log("leaving equation checker");
        }
    }
}
