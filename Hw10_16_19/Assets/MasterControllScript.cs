using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterControllScript : MonoBehaviour
{
    public GameObject cube;
    public GameObject sphere;
    public GameObject capsule;
    public GameObject cylinder;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.RightControl))
        {
            
                Instantiate(sphere, new Vector3(0, 2, 0), Quaternion.identity);

        }

        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            
                Instantiate(capsule, new Vector3(0, 5, 0), Quaternion.identity);
            
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {

                Instantiate(cube, new Vector3(0, -4, 0), Quaternion.identity);

        }

        if (Input.GetKeyUp(KeyCode.RightShift))
        {

                Instantiate(cylinder, new Vector3(0, -1, 0), Quaternion.identity);

        }

        transform.position = new Vector3(0, Mathf.Sin(Time.time * 5));
    }
}
