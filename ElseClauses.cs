using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElseClauses : MonoBehaviour {
    //My understanding of else clauses is something that you pair with "if statements". You are basically telling the program to look for something, and if it sees it to do something. The else clause comes in if it doesnt see it. If this doesnt happen then do this other thing. That is my basic understanding of it. 

    public bool myBool;
    public string myString = "basketball";
    public int num1;
    public int num2;


	// Use this for initialization
	void Start () {

        if (myBool)
        {
            print(true);
        }
        else
        {
            print(false);
        }

        if(myString == "basketball")
        {
            print(true);
        }
        else
        {
            print(false);
        }

        if (num1 + num2 == 10)
        {
            print(10);
        }
        else
        {
            print(false);
        }

        if(num1 + num2 == 100)
        {
            print(100);
        }
        else
        {
            print(num1 + num2);
        }

        if(num1 + num2 == 1000)
        {
            print(true);
        }
        else
        {
            print(num1);
        }

		
	}
	
	
}
