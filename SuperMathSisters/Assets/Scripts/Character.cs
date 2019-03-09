using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//this class handles the movement of the character
public class Character : MonoBehaviour
{
  
    public LayerMask groundLayer; //used to see if the player is on the ground or not    
    float moveHorzontal = 0f;
    public float moveSpeed = 0.5f; //the speed of character movement
    public Vector2 jumpHeight; //the height of the jump

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(Input.GetAxisRaw("Horizontal"));
        moveHorzontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))  //makes player jump  gotten from https://stackoverflow.com/questions/25350411/unity-2d-jumping-script
        {
            if (!IsGrounded())
            {
                return;
            }
            else
            {
                GetComponent<Rigidbody2D>().AddForce(jumpHeight, ForceMode2D.Impulse);
            }
        }
    }

    //move our character
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
           // Debug.Log("left arrow");
            transform.position += Vector3.right * -moveSpeed * Time.deltaTime;

        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            //Debug.Log("right arrow");
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;

        }
        else
        {
            transform.position += Vector3.right * 0 * Time.deltaTime;

        }

    }

    //true if the player is on the ground, false otherwise.
    bool IsGrounded() // from https://kylewbanks.com/blog/unity-2d-checking-if-a-character-or-object-is-on-the-ground-using-raycasts  helps with jumping
    {
       // Debug.Log("inside  grounded function ");

        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 1.0f;


        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, groundLayer);
        if (hit.collider != null) //If the collider is not null, that means there was an object found and we are on the ground
        {
          //  Debug.Log("return true");

            return true;
        }
        //Debug.Log("return false");
        Debug.DrawRay(position, direction, Color.green, 5.0f);

        return false;
    }
}
