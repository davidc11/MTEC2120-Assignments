using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentController : MonoBehaviour
{
    public Transform MakeBigger;
    public Transform MakeSmaller;
    public GameObject blue;
    public GameObject red;
    public bool ChangeBlueAndRedToDifferentColors;
    public bool ChangeMakeBiggerAndGetSmallerToBeExactOpposites;
    public bool ChangeLeftToRightAndViceVersa;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MakeBigger.transform.localScale = new Vector3(5, 5, 5);
        MakeSmaller.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

        var blueRenderer = blue.GetComponent<Renderer>();
        blueRenderer.material.SetColor("_Color", Color.blue);

        var redRenderer = red.GetComponent<Renderer>();
        redRenderer.material.SetColor("_Color", Color.red);

        if (ChangeBlueAndRedToDifferentColors == true)
        {
            var greenRenderer = blue.GetComponent<Renderer>();
            greenRenderer.material.SetColor("_Color", Color.green);
            var yellowRenderer = red.GetComponent<Renderer>();
            yellowRenderer.material.SetColor("_Color", Color.yellow);
        }

        if (ChangeMakeBiggerAndGetSmallerToBeExactOpposites == true)
        {
            MakeBigger.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            MakeSmaller.transform.localScale = new Vector3(5, 5, 5);
        }
        if (ChangeLeftToRightAndViceVersa == true)
        {
            MakeBigger.transform.position = new Vector3(-5, -2);
            MakeSmaller.transform.position = new Vector3(-5, 2);
            blue.transform.position = new Vector3(5, 2);
            red.transform.position = new Vector3(5, -2);
        }
        else
        {
            MakeBigger.transform.position = new Vector3(5, -2);
            MakeSmaller.transform.position = new Vector3(5, 2);
            blue.transform.position = new Vector3(-5, 2);
            red.transform.position = new Vector3(-5, -2);
        }
        
        
    }
    }

