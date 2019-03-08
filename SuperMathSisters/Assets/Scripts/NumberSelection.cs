using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberSelection : MonoBehaviour
{
    public Text leftHand;
    public Text rightHand;

    List<GameObject> numbers = new List<GameObject>(); 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    //need to send this function object to update array if there is a spot avail
    public void UpdateEquation(GameObject number)
    {
        //check if there is space in the array
        if (numbers.Count < 2)
        {
            //check to see if the GameObject passed in exists in the array already
            if (numbers.Contains(number))
            {
                // if the number exists remove (since this function is called when the button is pressed) 
                numbers.Remove(number);
                //need to make sure that when you remove an item from the array does it go back to null?
            }
            else // if not then add in the number
            {
                for(int i = 0; i < numbers.Count; i++)
                {
                    if(numbers[i] == null)
                    {
                        numbers[i] = number;
                        break;
                    }
                }
            }


            //update the display of function
            //if spot in the array is null, then fill with question mark
            //else fill with the number

        }
    }
}
