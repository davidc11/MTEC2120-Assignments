using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonUserInteraction : MonoBehaviour
{
    Vector3 positionOffset;
    // Start is called before the first frame update
    void Start()
    {
       positionOffset = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(5 * Mathf.Tan(Time.time), transform.position.y, 0) + positionOffset;
    }
}
