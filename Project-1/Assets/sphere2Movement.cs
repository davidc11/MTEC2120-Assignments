﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere2Movement : MonoBehaviour
{
    public float speed = 5;
    Vector3 positionSpace;
    // Start is called before the first frame update
    void Start()
    {
        positionSpace = transform.position; //Keeps position of sphere on screen
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time * speed, 10), 0, 0) + positionSpace; // Moves spheres across screen and returns back to center
    }
}
