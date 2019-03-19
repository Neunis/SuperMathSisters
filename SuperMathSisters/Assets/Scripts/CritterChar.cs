using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CritterChar : MonoBehaviour
{
    float dirX, dirY;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        dirX = Input.GetAxis("Horizontal");
        dirY = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(dirX * 5, dirY * 5);
    }
}
