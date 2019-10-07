using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonUserInteraction : MonoBehaviour
{

    Vector3 positionOffset;
    // Start is called before the first frame update
    void Start()
    {
       positionOffset = transform.position; //Keeps position of sphere on screen
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(-10 * Mathf.Sin(Time.time * 0.75f ), 0, 0) + positionOffset; // Moves spheres across screen and returns back to center
    }
}
