using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    //this script handles the collider functionality for falling to your death in the level. just calls the GM to tell the game to end.
    public GameObject GM;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        GM.GetComponent<GM>().endLevelMenuPopUp("Try Again!");
    }
}
