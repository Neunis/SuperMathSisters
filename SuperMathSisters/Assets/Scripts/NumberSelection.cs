using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberSelection : MonoBehaviour
{
    public GameObject num6Collider;
    public GameObject num3Collider;
    public GameObject num4Collider;
    public GameObject num1Collider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        num6Collider.GetComponent<Number>().getIsPicked();

    }
}
