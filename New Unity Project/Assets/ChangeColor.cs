using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) {
            GetComponent<Renderer>().material.color = Color.red;
            print("Changed color to red.");
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
            print("Changed color to Green.");
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
            print("Changed color to Blue.");
        }
        if (Input.GetKeyDown(KeyCode.Delete))
        {
            GetComponent<Renderer>().material.color = Color.white;
            print("Changed color to Blue.");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Renderer>().material.color = Color.black;
            print("Changed color to Blue.");
        }
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            GetComponent<Renderer>().material.color = Color.yellow;
            print("Changed color to Blue.");
        }



    }
}